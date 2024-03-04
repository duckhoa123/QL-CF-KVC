using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class BrokenInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;
        DataTable _detailTable;

        public BrokenInput()
        {
            Init();
            _detailTable = new DataTable();
            _detailTable.Columns.Add("ma_ph");
            _detailTable.Columns.Add("stt", typeof(int));
            _detailTable.Columns.Add("ma_vt");
            _detailTable.Columns.Add("so_luong", typeof(long));
            _detailTable.Columns.Add("ghi_chu");
            _detailTable.Columns.Add("ly_do");
            _detailTable.Columns.Add("tong_tien", typeof(long));
            gvDetail.DataSource = _detailTable;
            _detailTable.TableName = "Detail";
        }

        public BrokenInput(DataRow itemRow, DataTable detail)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_ph"].ToString();
            dpDate.Value = Convert.ToDateTime(itemRow["ngay_lap"]);
            rNote.Text = itemRow["ghi_chu"].ToString();
            txtQty.Text = itemRow["so_luong"].ToString();
            txtTotal.Text = itemRow["tong_tien"].ToString();
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
                .AddRowValue("so_luong", Convert.ToInt64(txtQty.Text))
                .AddRowValue("tong_tien", Convert.ToInt64(txtTotal.Text))
                .AddRowValue("trang_thai", cbStatus.SelectedValue)).AddTable(_detailTable.Copy())));
        }

        void OnNewClicked(object sender, EventArgs e)
        {
            var detail = new BrokenDetailInput(FormAction.New);
            detail.SaveClicked += OnDetailNewClicked;
            detail.ShowDialog();
        }

        void OnEditClicked(object sender, EventArgs e)
        {
            if (gvDetail.SelectedRows.Count == 0) return;
            var selectionRow = gvDetail.SelectedRows[0];
            if (selectionRow.DataBoundItem is not DataRowView rowView) return;
            var detail = new BrokenDetailInput(FormAction.New, rowView.Row);
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
            txtQty.EnableNumeric();
            txtTotal.EnableNumeric();
            cbStatus.DataSource = BrokenStatusDataSource.Instance;
        }

        void CalcMaster(DataTable table)
        {
            long sl = 0, total = 0;
            foreach (DataRow row in table.Rows)
            {
                sl += Convert.ToInt64(row["so_luong"]);
                total += Convert.ToInt64(row["tong_tien"]);
            }
            txtQty.Text = sl.ToString();
            txtTotal.Text = total.ToString();
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
