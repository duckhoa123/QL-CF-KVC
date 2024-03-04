using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class PlaceInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public PlaceInput()
        {
            Init();
        }

        public PlaceInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_khu"].ToString();
            txtName.Text = itemRow["ten_khu"].ToString();
            cbTt.SelectedValue = itemRow["tinh_trang"];
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_khu", txtCode.Text)
                .AddRowValue("ten_khu", txtName.Text)
                .AddRowValue("tinh_trang", cbTt.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            cbTt.DataSource = AvaiablePlaceDataSource.Instance;
            cbStatus.DataSource = StatusDataSource.Instance;
        }
    }
}
