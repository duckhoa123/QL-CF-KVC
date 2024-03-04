using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormBrokens : FormBase
    {
        protected override string Controller => "Broken";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Brokens", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_ph"].HeaderText = "Mã phiếu";
            GridView.Columns["ngay_lap"].HeaderText = "Ngày lập";
            GridView.Columns["ghi_chu"].HeaderText = "Ghi chú";
            GridView.Columns["so_luong"].HeaderText = "Số lượng";
            GridView.Columns["tong_tien"].HeaderText = "Giá trị ước tính";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";

            if (GridView.Columns["xtype"] is DataGridViewColumn col)
            {
                col.Visible = false;
            }
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var itemInput = new BrokenInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var ds = DataCenter.Instance.ExecuteDataSet(Controller, "BrokenByID", Utils.DataFromArray(new Param("ma_ph", row.Cells["ma_ph"].Value)), 0);
            var itemInput = new BrokenInput(ds.Tables[0].Rows[0], ds.Tables[1]);
            itemInput.Text = string.Format(itemInput.Text, "Sửa");
            itemInput.SaveClicked += OnEdit;
            itemInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteBroken", Utils.DataFromArray(new Param("ma_ph", row.Cells["ma_ph"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_ph = '{row.Cells["ma_ph"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not BrokenInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertBroken", e.Value, 0);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.AddCloneRow(row);
            SetDataSource(ViewGrid);

            input.Close();
        }

        void OnEdit(object sender, DataSetArgs e)
        {
            if (sender is not BrokenInput input) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_ph_old", selectRow.Cells["ma_ph"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditBroken", e.Value, 0, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_ph = '{selectRow.Cells["ma_ph"].Value}'")[0]), row);

            input.Close();
        }
    }
}
