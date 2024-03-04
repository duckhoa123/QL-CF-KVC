using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormChecks : FormBase
    {
        protected override string Controller => "Check";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Checks", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_ph"].HeaderText = "Mã phiếu";
            GridView.Columns["ngay_lap"].HeaderText = "Ngày lập";
            GridView.Columns["ghi_chu"].HeaderText = "Ghi chú";
            GridView.Columns["so_luong1"].HeaderText = "Số lượng kế toán";
            GridView.Columns["tong_tien1"].HeaderText = "Tổng tiền kế toán";
            GridView.Columns["so_luong2"].HeaderText = "Số lượng kiểm kê";
            GridView.Columns["tong_tien2"].HeaderText = "Tổng tiền kiểm kê";
            GridView.Columns["so_luong3"].HeaderText = "Số lượng thừa";
            GridView.Columns["tong_tien3"].HeaderText = "Tổng tiền thừa";
            GridView.Columns["so_luong4"].HeaderText = "Số lượng thiếu";
            GridView.Columns["tong_tien4"].HeaderText = "Tổng tiền thiếu";
            GridView.Columns["full_quality"].HeaderText = "Tốt 100%";
            GridView.Columns["poor_quality"].HeaderText = "Kém phẩm chất";
            GridView.Columns["loss_quality"].HeaderText = "Mất phẩm chất";
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
            var itemInput = new CheckInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var ds = DataCenter.Instance.ExecuteDataSet(Controller, "CheckByID", Utils.DataFromArray(new Param("ma_ph", row.Cells["ma_ph"].Value)), 0);
            var itemInput = new CheckInput(ds.Tables[0].Rows[0], ds.Tables[1]);
            itemInput.Text = string.Format(itemInput.Text, "Sửa");
            itemInput.SaveClicked += OnEdit;
            itemInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteCheck", Utils.DataFromArray(new Param("ma_ph", row.Cells["ma_ph"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_ph = '{row.Cells["ma_ph"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not CheckInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertCheck", e.Value, 0);
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
            if (sender is not CheckInput input) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_ph_old", selectRow.Cells["ma_ph"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditCheck", e.Value, 0, 2);

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
