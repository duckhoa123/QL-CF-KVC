using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class CheckInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;
        DataTable _detailTable;

        public CheckInput()
        {
            Init();
            _detailTable = new DataTable();
            _detailTable.Columns.Add("ma_ph");
            _detailTable.Columns.Add("stt", typeof(int));
            _detailTable.Columns.Add("ma_vt");
            _detailTable.Columns.Add("so_luong1", typeof(long));
            _detailTable.Columns.Add("tong_tien1", typeof(long));
            _detailTable.Columns.Add("so_luong2", typeof(long));
            _detailTable.Columns.Add("tong_tien2", typeof(long));
            _detailTable.Columns.Add("so_luong3", typeof(long));
            _detailTable.Columns.Add("tong_tien3", typeof(long));
            _detailTable.Columns.Add("so_luong4", typeof(long));
            _detailTable.Columns.Add("tong_tien4", typeof(long));
            _detailTable.Columns.Add("full_quality", typeof(long));
            _detailTable.Columns.Add("poor_quality", typeof(long));
            _detailTable.Columns.Add("loss_quality", typeof(long));
            gvDetail.DataSource = _detailTable;
            _detailTable.TableName = "Detail";
        }

        public CheckInput(DataRow itemRow, DataTable detail)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_ph"].ToString();
            dpDate.Value = Convert.ToDateTime(itemRow["ngay_lap"]);
            rNote.Text = itemRow["ghi_chu"].ToString();
            txtQty1.Text = itemRow["so_luong1"].ToString();
            txtTotal1.Text = itemRow["tong_tien1"].ToString();
            txtQty2.Text = itemRow["so_luong2"].ToString();
            txtTotal2.Text = itemRow["tong_tien2"].ToString();
            txtQty3.Text = itemRow["so_luong3"].ToString();
            txtTotal3.Text = itemRow["tong_tien3"].ToString();
            txtQty4.Text = itemRow["so_luong4"].ToString();
            txtTotal4.Text = itemRow["tong_tien4"].ToString();
            txtFull.Text = itemRow["full_quality"].ToString();
            txtPoor.Text = itemRow["poor_quality"].ToString();
            txtLoss.Text = itemRow["loss_quality"].ToString();
            cbStatus.SelectedValue = itemRow["trang_thai"];
            gvDetail.DataSource = _detailTable = detail;
            _detailTable.TableName = "Detail";
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_ph", txtCode.Text)
                .AddRowValue("ngay_lap", dpDate.Value, typeof(DateTime))
                .AddRowValue("ghi_chu", rNote.Text)
                .AddRowValue("so_luong1", Convert.ToInt64(txtQty1.Text))
                .AddRowValue("tong_tien1", Convert.ToInt64(txtTotal1.Text))
                .AddRowValue("so_luong2", Convert.ToInt64(txtQty2.Text))
                .AddRowValue("tong_tien2", Convert.ToInt64(txtTotal2.Text))
                .AddRowValue("so_luong3", Convert.ToInt64(txtQty3.Text))
                .AddRowValue("tong_tien3", Convert.ToInt64(txtTotal3.Text))
                .AddRowValue("so_luong4", Convert.ToInt64(txtQty4.Text))
                .AddRowValue("tong_tien4", Convert.ToInt64(txtTotal4.Text))
                .AddRowValue("full_quality", Convert.ToInt64(txtFull.Text))
                .AddRowValue("poor_quality", Convert.ToInt64(txtPoor.Text))
                .AddRowValue("loss_quality", Convert.ToInt64(txtLoss.Text))
                .AddRowValue("trang_thai", cbStatus.SelectedValue)).AddTable(_detailTable.Copy())));
        }

        void OnNewClicked(object sender, EventArgs e)
        {
            var detail = new CheckDetailInput(FormAction.New);
            detail.SaveClicked += OnDetailNewClicked;
            detail.ShowDialog();
        }

        void OnEditClicked(object sender, EventArgs e)
        {
            if (gvDetail.SelectedRows.Count == 0) return;
            var selectionRow = gvDetail.SelectedRows[0];
            if (selectionRow.DataBoundItem is not DataRowView rowView) return;
            var detail = new CheckDetailInput(FormAction.New, rowView.Row);
            detail.SaveClicked += OnDetailEditClicked;
            detail.ShowDialog();

            void OnDetailEditClicked(object sender, DataSetArgs e)
            {
                if (sender is Form form) form.Close();
                if (_detailTable == null) _detailTable = e.Value.Tables[0];
                _detailTable.UpdateRow(_detailTable.Rows.IndexOf(rowView.Row), e.Value.Tables[0].Rows[0]);
                CalcMaster(_detailTable);
                gvDetail.DataSource = _detailTable;
            }
        }

        void OnDetailNewClicked(object sender, DataSetArgs e)
        {
            if (sender is Form form) form.Close();
            if (_detailTable == null) _detailTable = e.Value.Tables[0];
            var index = _detailTable.Rows.Count;
            _detailTable.AddCloneRow(e.Value.Tables[0].Rows[0]);
            _detailTable.AddRowValue(index, "stt", index + 1, typeof(int));
            CalcMaster(_detailTable);
            gvDetail.DataSource = _detailTable;
        }

        void OnBtnDeleteClicked(object sender, EventArgs e)
        {
            if (gvDetail.SelectedRows.Count == 0) return;
            var selectionRow = gvDetail.SelectedRows[0];
            if (selectionRow.DataBoundItem is not DataRowView rowView) return;
            _detailTable.Rows.Remove(rowView.Row);
            RefreshLine();
            CalcMaster(_detailTable);
            gvDetail.DataSource = _detailTable;
        }

        void Init()
        {
            InitializeComponent();
            txtQty1.EnableNumeric();
            txtTotal1.EnableNumeric();
            cbStatus.DataSource = BrokenStatusDataSource.Instance;
        }

        void CalcMaster(DataTable table)
        {
            long sl1 = 0, total1 = 0, sl2 = 0, total2 = 0, sl3 = 0, total3 = 0, sl4 = 0, total4 = 0, full = 0, poor = 0, loss = 0;
            foreach (DataRow row in table.Rows)
            {
                sl1 += Convert.ToInt64(row["so_luong1"]);
                total1 += Convert.ToInt64(row["tong_tien1"]);
                sl2 += Convert.ToInt64(row["so_luong2"]);
                total2 += Convert.ToInt64(row["tong_tien2"]);
                sl3 += Convert.ToInt64(row["so_luong3"]);
                total3 += Convert.ToInt64(row["tong_tien3"]);
                sl4 += Convert.ToInt64(row["so_luong4"]);
                total4 += Convert.ToInt64(row["tong_tien4"]);
                full += Convert.ToInt64(row["full_quality"]);
                poor += Convert.ToInt64(row["poor_quality"]);
                loss += Convert.ToInt64(row["loss_quality"]);
            }
            txtQty1.Text = sl1.ToString();
            txtTotal1.Text = total1.ToString();
            txtQty2.Text = sl2.ToString();
            txtTotal2.Text = total2.ToString();
            txtQty3.Text = sl3.ToString();
            txtTotal3.Text = total3.ToString();
            txtQty4.Text = sl4.ToString();
            txtTotal4.Text = total4.ToString();
            txtFull.Text = full.ToString();
            txtPoor.Text = poor.ToString();
            txtLoss.Text = loss.ToString();
        }

        void RefreshLine()
        {
            for (int i = 1; i <= _detailTable.Rows.Count; i++)
            {
                _detailTable.Rows[i - 1]["stt"] = i;
            }
        }
    }
}
