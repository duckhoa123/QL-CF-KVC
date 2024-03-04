using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class RentBookDetailInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public FormAction FormAction { get; }

        public RentBookDetailInput(FormAction action)
        {
            Init();

            FormAction = action;
        }

        public RentBookDetailInput(FormAction action, DataRow itemRow)
        {
            Init();
            FormAction = action;
            if (itemRow == null) return;
            cbItem.SelectedValue = itemRow["ma_vt"].ToString();
            txtQty.Text = itemRow["so_luong"].ToString();
            txtSubtotal.Text = itemRow["tien_hang"].ToString();
            txtDiscount.Text = itemRow["khuyen_mai"].ToString();
            txtTax.Text = itemRow["tien_thue"].ToString();
            txtTotal.Text = itemRow["tong_tien"].ToString();
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_vt", cbItem.SelectedValue)
                .AddRowValue("so_luong", Convert.ToInt64(txtQty.Text))
                .AddRowValue("tien_hang", Convert.ToInt64(txtSubtotal.Text))
                .AddRowValue("khuyen_mai", Convert.ToInt64(txtDiscount.Text))
                .AddRowValue("tien_thue", Convert.ToInt64(txtTax.Text))
                .AddRowValue("tong_tien", Convert.ToInt64(txtTotal.Text)))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
            txtSubtotal.EnableNumeric();
            txtTax.EnableNumeric();
            txtTotal.EnableNumeric();
            txtDiscount.EnableNumeric();
            cbItem.DataSource = DataCenter.Instance.ExecuteDataTable("Book", "BooksAsItems", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }
    }
}
