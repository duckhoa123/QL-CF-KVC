using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormBookTypes : FormBase
    {
        protected override string Controller => "BookType";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "BookTypes", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_loai_sach"].HeaderText = "Mã loại sách";
            GridView.Columns["ten_loai_sach"].HeaderText = "Tên loại sách";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var bookTypeInput = new BookTypeInput();
            bookTypeInput.Text = string.Format(bookTypeInput.Text, "Thêm");
            bookTypeInput.SaveClicked += OnInsert;
            bookTypeInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var bookTypeInput = new BookTypeInput(DataCenter.Instance.ExecuteDataRow(Controller, "BookTypeByID", Utils.DataFromArray(new Param("ma_loai_sach", row.Cells["ma_loai_sach"].Value)), 0));
            bookTypeInput.Text = string.Format(bookTypeInput.Text, "Sửa");
            bookTypeInput.SaveClicked += OnEdit;
            bookTypeInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteBookType", Utils.DataFromArray(new Param("ma_loai_sach", row.Cells["ma_loai_sach"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_loai_sach = '{row.Cells["ma_loai_sach"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not BookTypeInput bookTypeInput) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertBookType", e.Value, 0, 1, 2);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.AddCloneRow(row);
            SetDataSource(ViewGrid);

            bookTypeInput.Close();
        }

        void OnEdit(object sender, DataSetArgs e)
        {
            if (sender is not BookTypeInput bookTypeInput) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_loai_sach_old", selectRow.Cells["ma_loai_sach"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditBookType", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_loai_sach = '{selectRow.Cells["ma_loai_sach"].Value}'")[0]), row);

            bookTypeInput.Close();
        }

        private void InitializeComponent ( )
        {
            this.SuspendLayout();
            // 
            // FormBookTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Name = "FormBookTypes";
            this.ResumeLayout(false);

        }
    }
}
