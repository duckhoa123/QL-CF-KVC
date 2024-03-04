using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormEmployees : FormBase
    {
        protected override string Controller => "Employee";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Employees", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_nv"].HeaderText = "Mã nhân viên";
            GridView.Columns["ten_nv"].HeaderText = "Tên nhân viên";
            GridView.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            GridView.Columns["ngay_bd"].HeaderText = "Ngày bắt đầu làm việc";
            GridView.Columns["gioi_tinh"].HeaderText = "Giới tính";
            GridView.Columns["muc_luong"].HeaderText = "Mức lương";
            GridView.Columns["muc_luong"].HeaderText = "Mức lương";
            GridView.Columns["nsd"].HeaderText = "Người sử dụng";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var itemInput = new EmployeeInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var itemInput = new EmployeeInput(DataCenter.Instance.ExecuteDataRow(Controller, "EmployeeByID", Utils.DataFromArray(new Param("ma_nv", row.Cells["ma_nv"].Value)), 0));
            itemInput.Text = string.Format(itemInput.Text, "Sửa");
            itemInput.SaveClicked += OnEdit;
            itemInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteEmployee", Utils.DataFromArray(new Param("ma_nv", row.Cells["ma_nv"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_nv = '{row.Cells["ma_nv"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not EmployeeInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertEmployee", e.Value, 0, 1, 2);
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
            if (sender is not EmployeeInput input) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_nv_old", selectRow.Cells["ma_nv"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditEmployee", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_nv = '{selectRow.Cells["ma_nv"].Value}'")[0]), row);

            input.Close();
        }
    }
}
