using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class BookTypeInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public BookTypeInput()
        {
            Init();
        }

        public BookTypeInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_loai_sach"].ToString();
            txtName.Text = itemRow["ten_loai_sach"].ToString();
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_loai_sach", txtCode.Text)
                .AddRowValue("ten_loai_sach", txtName.Text)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            cbStatus.DataSource = StatusDataSource.Instance;
        }
    }
}
