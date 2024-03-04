using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class BrokenDetailInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public FormAction FormAction { get; }

        public BrokenDetailInput(FormAction action)
        {
            Init();

            FormAction = action;
        }

        public BrokenDetailInput(FormAction action, DataRow itemRow)
        {
            Init();
            FormAction = action;
            if (itemRow == null) return;
            cbItem.SelectedValue = itemRow["ma_vt"].ToString();
            txtQty.Text = itemRow["so_luong"].ToString();
            txtTotal.Text = itemRow["tong_tien"].ToString();
            rReason.Text = itemRow["ly_do"].ToString();
            rNote.Text = itemRow["ghi_chu"].ToString();
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_vt", cbItem.SelectedValue)
                .AddRowValue("so_luong", Convert.ToInt64(txtQty.Text))
                .AddRowValue("ly_do", rReason.Text)
                .AddRowValue("ghi_chu", rNote.Text)
                .AddRowValue("tong_tien", Convert.ToInt64(txtTotal.Text)))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
            txtTotal.EnableNumeric();
            cbItem.DataSource = DataCenter.Instance.ExecuteDataTable("Item", "Item", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }
    }
}
