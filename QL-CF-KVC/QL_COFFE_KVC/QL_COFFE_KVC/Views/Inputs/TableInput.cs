using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class TableInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public TableInput()
        {
            Init();
        }

        public TableInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_ban"].ToString();
            txtName.Text = itemRow["ten_ban"].ToString();
            txtQty.Text = itemRow["size"].ToString();
            cbTt.SelectedValue = itemRow["tinh_trang"];
            cbPlace.SelectedValue = itemRow["ma_khu"];
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_ban", txtCode.Text)
                .AddRowValue("ten_ban", txtName.Text)
                .AddRowValue("size", Convert.ToInt32(txtQty.Text), typeof(int))
                .AddRowValue("tinh_trang", cbTt.SelectedValue)
                .AddRowValue("ma_khu", cbPlace.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
            cbTt.DataSource = AvaiableTableDataSource.Instance;
            cbStatus.DataSource = StatusDataSource.Instance;
            cbPlace.DataSource = DataCenter.Instance.ExecuteDataTable("Place", "Places", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }
    }
}
