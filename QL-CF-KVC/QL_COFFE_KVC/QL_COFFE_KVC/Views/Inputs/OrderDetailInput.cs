using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class OrderDetailInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public FormAction FormAction { get; }

        public OrderDetailInput(FormAction action)
        {
            Init();

            FormAction = action;
        }

        public OrderDetailInput(FormAction action, DataRow itemRow)
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
            txtQty.TextChanged += OnItemPriceChanged;
            txtTax.TextChanged += OnItemPriceChanged;
            txtDiscount.TextChanged += OnItemPriceChanged;
            cbItem.DataSource = DataCenter.Instance.ExecuteDataTable("Item", "Item", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
        }

        void OnItemPriceChanged(object sender, EventArgs e)
        {
            if (cbItem.SelectedItem is not DataRowView rowV) return;
            var price = Convert.ToInt64(rowV["gia_ban"]);
            var qty = Convert.ToInt64(txtQty.Text);
            txtSubtotal.Text = (price * qty).ToString();
            txtTotal.Text = (Convert.ToInt64(txtSubtotal.Text) - Convert.ToInt64(txtDiscount.Text) + Convert.ToInt64(txtTax.Text)).ToString();
        }
    }
}
