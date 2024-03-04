using QL_COFFE_KVC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class FormMaterials : FormBase
    {
        protected override string Controller => "Material";
        protected override void LoadData()
        {
            ViewGrid = DataCenter.Instance.ExecuteDataTable(Controller, "Materials", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            SetDataSource(ViewGrid);
        }

        protected override void InitColumns()
        {
            GridView.Columns["ma_vl"].HeaderText = "Mã vật liệu";
            GridView.Columns["ten_vl"].HeaderText = "Tên vật liệu";
            GridView.Columns["sl_ton"].HeaderText = "Số lượng tồn";
            GridView.Columns["ma_ncc"].HeaderText = "Nhà cung cấp";
            GridView.Columns["trang_thai"].HeaderText = "Trạng thái";
            GridView.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            GridView.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            GridView.Columns["nguoi_tao"].HeaderText = "Người tạo";
            GridView.Columns["nguoi_sua"].HeaderText = "Người sửa";
        }

        protected override void OnNewClicked(object sender, EventArgs e)
        {
            base.OnNewClicked(sender, e);
            var itemInput = new MaterialInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        protected override void OnEditClicked(object sender, EventArgs e)
        {
            base.OnEditClicked(sender, e);
            if (GetSelectionRow() is not DataGridViewRow row) return;
            var itemInput = new MaterialInput(DataCenter.Instance.ExecuteDataRow(Controller, "MaterialByID", Utils.DataFromArray(new Param("ma_vl", row.Cells["ma_vl"].Value)), 0));
            itemInput.Text = string.Format(itemInput.Text, "Sửa");
            itemInput.SaveClicked += OnEdit;
            itemInput.ShowDialog(this);
        }

        protected override void OnDeleteClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow row) return;
            DataCenter.Instance.Execute(Controller, "DeleteMaterial", Utils.DataFromArray(new Param("ma_vl", row.Cells["ma_vl"].Value)), 0);
            ViewGrid.Rows.RemoveAt(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_vl = '{row.Cells["ma_vl"].Value}'")[0]));
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not MaterialInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertMaterial", e.Value, 0, 1, 2);
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
            if (sender is not MaterialInput input) return;
            if (GetSelectionRow() is not DataGridViewRow selectRow) return;

            var oldTable = new DataTable();
            oldTable.AddRowValue("ma_vl_old", selectRow.Cells["ma_vl"].Value);
            oldTable.AddRowValue("ngay_sua_old", selectRow.Cells["ngay_sua"].Value, typeof(DateTime));
            e.Value.Tables.Add(oldTable);

            var row = DataCenter.Instance.ExecuteDataRow(Controller, "EditMaterial", e.Value, 0, 1, 2);

            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            ViewGrid.UpdateRow(ViewGrid.Rows.IndexOf(ViewGrid.Select($"ma_vl = '{selectRow.Cells["ma_vl"].Value}'")[0]), row);

            input.Close();
        }
    }
}
