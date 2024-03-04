using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class ProviderInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public ProviderInput()
        {
            Init();
        }

        public ProviderInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_ncc"].ToString();
            txtName.Text = itemRow["ten_ncc"].ToString();
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_ncc", txtCode.Text)
                .AddRowValue("ten_ncc", txtName.Text)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            cbStatus.DataSource = StatusDataSource.Instance;
        }
    }
}
