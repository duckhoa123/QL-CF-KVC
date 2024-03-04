using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class CheckDetailInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public FormAction FormAction { get; }

        public CheckDetailInput(FormAction action)
        {
            Init();
            FormAction = action;
        }

        public CheckDetailInput(FormAction action, DataRow itemRow)
        {
            Init();
            FormAction = action;
            if (itemRow == null) return;
            cbItem.SelectedValue = itemRow["ma_vt"].ToString();
            txtQty1.Text = itemRow["so_luong1"].ToString();
            txtTotal1.Text = itemRow["tong_tien1"].ToString();
            txtQty2.Text = itemRow["so_luong2"].ToString();
            txtTotal2.Text = itemRow["tong_tien2"].ToString();
            txtQty3.Text = itemRow["so_luong3"].ToString();
            txtTotal3.Text = itemRow["tong_tien3"].ToString();
            txtQty4.Text = itemRow["so_luong4"].ToString();
            txtTotal4.Text = itemRow["tong_tien4"].ToString();
            txtFull.Text = itemRow["full_quality"].ToString();
            txtPoor.Text = itemRow["poor_quality"].ToString();
            txtLoss.Text = itemRow["loss_quality"].ToString();
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            if (cbItem.SelectedValue == null) return;
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_vt", cbItem.SelectedValue)
                .AddRowValue("so_luong1", Convert.ToInt64(txtQty1.Text))
                .AddRowValue("tong_tien1", Convert.ToInt64(txtTotal1.Text))
                .AddRowValue("so_luong2", Convert.ToInt64(txtQty2.Text))
                .AddRowValue("tong_tien2", Convert.ToInt64(txtTotal2.Text))
                .AddRowValue("so_luong3", Convert.ToInt64(txtQty3.Text))
                .AddRowValue("tong_tien3", Convert.ToInt64(txtTotal3.Text))
                .AddRowValue("so_luong4", Convert.ToInt64(txtQty4.Text))
                .AddRowValue("tong_tien4", Convert.ToInt64(txtTotal4.Text))
                .AddRowValue("full_quality", Convert.ToInt64(txtFull.Text))
                .AddRowValue("poor_quality", Convert.ToInt64(txtPoor.Text))
                .AddRowValue("loss_quality", Convert.ToInt64(txtLoss.Text)))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty1.EnableNumeric();
            txtTotal1.EnableNumeric();
            txtQty2.EnableNumeric();
            txtTotal2.EnableNumeric();
            txtQty3.EnableNumeric();
            txtTotal3.EnableNumeric();
            txtQty4.EnableNumeric();
            txtTotal4.EnableNumeric();
            txtFull.EnableNumeric();
            txtPoor.EnableNumeric();
            txtLoss.EnableNumeric();
            cbItem.DataSource = DataCenter.Instance.ExecuteDataTable("Item", "Item", Utils.DataFromArray(new Param("trang_thai", "1")), 0);
            txtQty1.TextChanged += OnQtyTextChanged;
            txtQty2.TextChanged += OnQtyTextChanged;
            txtTotal1.TextChanged += OnTotalTextChanged;
            txtTotal2.TextChanged += OnTotalTextChanged;
        }

        void OnTotalTextChanged(object sender, EventArgs e)
        {
            var total = Convert.ToInt64(txtTotal2.Text) - Convert.ToInt64(txtTotal1.Text);
            if (total > 0)
            {
                txtTotal3.Text = total.ToString();
                txtTotal4.Text = "0";
            }
            else
            {
                txtTotal3.Text = "0";
                txtTotal4.Text = (-total).ToString();
            }
        }

        void OnQtyTextChanged(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt64(txtQty2.Text) - Convert.ToInt64(txtQty1.Text);
            if (quantity > 0)
            {
                txtQty3.Text = quantity.ToString();
                txtQty4.Text = "0";
            }
            else
            {
                txtQty3.Text = "0";
                txtQty4.Text = (-quantity).ToString();
            }
        }
    }
}
