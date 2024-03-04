using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class TicketInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        const int ROOT_TICKET_PRICE = 100000;

        public TicketInput()
        {
            Init();
        }

        public TicketInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCusName.Text = itemRow["ten_khach"].ToString();
            txtCusContact.Text = itemRow["sdt_khach"].ToString();
            rNote.Text = itemRow["ghi_chu"].ToString();
            textTotal.Text = itemRow["tong_tien"].ToString();
            txtQty.Text = itemRow["so_luong"].ToString();
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_dh", 0L, typeof(long))
                .AddRowValue("ten_khach", txtCusName.Text)
                .AddRowValue("sdt_khach", txtCusContact.Text)
                .AddRowValue("ghi_chu", rNote.Text)
                .AddRowValue("xtype", "1")
                .AddRowValue("tong_tien", int.Parse(textTotal.Text), typeof(int))
                .AddRowValue("so_luong", int.Parse(txtQty.Text), typeof(int)))));
        }

        void Init()
        {
            InitializeComponent();
            txtQty.EnableNumeric();
        }

        void OnQuantityChanged(object sender, EventArgs e)
        {
            textTotal.Text = (int.Parse(string.IsNullOrEmpty(txtQty.Text) ? "0" : txtQty.Text) * ROOT_TICKET_PRICE).ToString();
        }
    }
}
