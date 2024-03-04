using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class ItemInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public ItemInput()
        {
            Init();
        }

        public ItemInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_vt"].ToString();
            txtName.Text = itemRow["ten_vt"].ToString();
            rDes.Text = itemRow["mo_ta"].ToString();
            txtQty.Text = itemRow["sl_ton"].ToString();
            txtPrice.Text = itemRow["gia_ban"].ToString();
            cbNcc.SelectedValue = itemRow["ma_ncc"];
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_vt", txtCode.Text)
                .AddRowValue("ten_vt", txtName.Text)
                .AddRowValue("mo_ta", rDes.Text)
                .AddRowValue("sl_ton", int.Parse(txtQty.Text))
                .AddRowValue("gia_ban", int.Parse(txtPrice.Text))
                .AddRowValue("ma_ncc", cbNcc.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
            txtPrice.EnableNumeric();
            cbStatus.DataSource = StatusDataSource.Instance;
            cbNcc.DataSource = DataCenter.Instance.ExecuteDataTable("Provider", "Providers", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }
    }
}
