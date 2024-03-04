using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class BookInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public BookInput ( )
        {
            Init();
        }

        public BookInput ( DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_sach"].ToString();
            txtName.Text = itemRow["ten_sach"].ToString();
            cbBookType.SelectedValue = itemRow["ma_loai_sach"].ToString();
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_sach", txtCode.Text)
                .AddRowValue("ten_sach", txtName.Text)
                .AddRowValue("ma_loai_sach", cbBookType.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            cbStatus.DataSource = StatusDataSource.Instance;
            cbBookType.DataSource = DataCenter.Instance.ExecuteDataTable("BookType", "BookTypes", null, 0);
        }
    }
}
