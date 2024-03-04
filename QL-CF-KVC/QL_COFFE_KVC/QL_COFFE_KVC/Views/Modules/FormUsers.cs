using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormUsers : FormBase
    {
        protected override string Controller => "User";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Users", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["id"].HeaderText = "Mã NSD";
            GridView.Columns["username"].HeaderText = "Tên đăng nhập";
            GridView.Columns["full_name"].HeaderText = "Tên đầy đủ";
            GridView.Columns["password"].HeaderText = "Mật khẩu";
            GridView.Columns["admin"].HeaderText = "Quản trị viên";
            GridView.Columns["manager"].HeaderText = "Quản lý";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var UserInput = new UserInput();
            UserInput.Text = string.Format(UserInput.Text, "Thêm");
            UserInput.SaveClicked += OnInsert;
            UserInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var UserInput = new UserInput(DataCenter.Instance.ExecuteDataRow(Controller, "UserByID", Utils.DataFromArray(new Param("id", row.Cells["id"].Value)), 0));
            UserInput.Text = string.Format(UserInput.Text, "Sửa");
            UserInput.SaveClicked += OnEdit;
            UserInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteUser", Utils.DataFromArray(new Param("id", row.Cells["id"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"id = '{row.Cells["id"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not UserInput UserInput) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertUser", e.Value, 0, 1, 2);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.AddCloneRow(row);
            SetDataSource(ViewGrid);

            UserInput.Close();
        }

        void OnEdit(object sender, DataSetArgs e)
        {
            if (sender is not UserInput UserInput) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("id_old", selectRow.Cells["id"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditUser", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"id = '{selectRow.Cells["id"].Value}'")[0]), row);

            UserInput.Close();
        }
    }
}
