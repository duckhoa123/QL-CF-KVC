using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class MaterialInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public MaterialInput()
        {
            Init();
        }

        public MaterialInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_vl"].ToString();
            txtName.Text = itemRow["ten_vl"].ToString();
            txtQty.Text = itemRow["sl_ton"].ToString();
            cbNcc.SelectedValue = itemRow["ma_ncc"];
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_vl", txtCode.Text)
                .AddRowValue("ten_vl", txtName.Text)
                .AddRowValue("sl_ton", int.Parse(txtQty.Text))
                .AddRowValue("ma_ncc", cbNcc.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
            cbStatus.DataSource = StatusDataSource.Instance;
            cbNcc.DataSource = DataCenter.Instance.ExecuteDataTable("Provider", "Providers", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }
    }
}
