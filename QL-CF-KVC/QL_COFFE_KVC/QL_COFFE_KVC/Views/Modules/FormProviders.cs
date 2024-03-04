using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormProviders : FormBase
    {
        protected override string Controller => "Provider";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Providers", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_ncc"].HeaderText = "Mã nhà cung cấp";
            GridView.Columns["ten_ncc"].HeaderText = "Tên nhà cung cấp";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var itemInput = new ProviderInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var itemInput = new ProviderInput(DataCenter.Instance.ExecuteDataRow(Controller, "ProviderByID", Utils.DataFromArray(new Param("ma_ncc", row.Cells["ma_ncc"].Value)), 0));
            itemInput.Text = string.Format(itemInput.Text, "Sửa");
            itemInput.SaveClicked += OnEdit;
            itemInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteProvider", Utils.DataFromArray(new Param("ma_ncc", row.Cells["ma_ncc"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_ncc = '{row.Cells["ma_ncc"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not ProviderInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertProvider", e.Value, 0, 1, 2);
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
            if (sender is not ProviderInput input) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_ncc_old", selectRow.Cells["ma_ncc"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditProvider", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_ncc = '{selectRow.Cells["ma_ncc"].Value}'")[0]), row);

            input.Close();
        }
    }
}
