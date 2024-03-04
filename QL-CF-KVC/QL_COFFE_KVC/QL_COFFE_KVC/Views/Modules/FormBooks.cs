using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormBooks : FormBase
    {
        protected override string Controller => "Book";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Books", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_sach"].HeaderText = "Mã sách";
            GridView.Columns["ten_sach"].HeaderText = "Tên sách";
            GridView.Columns["ma_loai_sach"].HeaderText = "Loại sách";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var bookInput = new BookInput();
            bookInput.Text = string.Format(bookInput.Text, "Thêm");
            bookInput.SaveClicked += OnInsert;
            bookInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var bookInput = new BookInput(DataCenter.Instance.ExecuteDataRow(Controller, "BookByID", Utils.DataFromArray(new Param("ma_sach", row.Cells["ma_sach"].Value)), 0));
            bookInput.Text = string.Format(bookInput.Text, "Sửa");
            bookInput.SaveClicked += OnEdit;
            bookInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteBook", Utils.DataFromArray(new Param("ma_sach", row.Cells["ma_sach"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_sach = '{row.Cells["ma_sach"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not BookInput bookInput) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertBook", e.Value, 0, 1, 2);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.AddCloneRow(row);
            SetDataSource(ViewGrid);

            bookInput.Close();
        }

        void OnEdit(object sender, DataSetArgs e)
        {
            if (sender is not BookInput bookInput) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_sach_old", selectRow.Cells["ma_sach"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditBook", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_sach = '{selectRow.Cells["ma_sach"].Value}'")[0]), row);

            bookInput.Close();
        }
    }
}
