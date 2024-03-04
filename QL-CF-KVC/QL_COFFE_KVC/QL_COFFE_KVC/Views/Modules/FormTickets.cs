using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class FormTickets : Form
    {
        readonly string Controller = "Ticket";
        DataTable GridData;
        public FormTickets()
        {
            InitializeComponent();
        }

        protected void InitColumns()
        {
            dtgv.Columns["ma_dh"].HeaderText = "Mã đơn hàng";
            dtgv.Columns["ngay_lap"].HeaderText = "Ngày lập";
            dtgv.Columns["ten_khach"].HeaderText = "Khách hàng";
            dtgv.Columns["sdt_khach"].HeaderText = "Số điện thoại";
            dtgv.Columns["ghi_chu"].HeaderText = "Ghi chú";
            dtgv.Columns["so_luong"].HeaderText = "Số lượng";
            dtgv.Columns["tien_hang"].HeaderText = "Tạm tính";
            dtgv.Columns["khuyen_mai"].HeaderText = "Khuyến mãi";
            dtgv.Columns["tien_thue"].HeaderText = "Thuế";
            dtgv.Columns["tong_tien"].HeaderText = "Thành tiền";
            dtgv.Columns["trang_thai"].HeaderText = "Trạng thái";
            dtgv.Columns["ngay_tao"].HeaderText = "Ngày tạo";
            dtgv.Columns["ngay_sua"].HeaderText = "Ngày sửa";
            dtgv.Columns["nguoi_tao"].HeaderText = "Người tạo";
            dtgv.Columns["nguoi_sua"].HeaderText = "Người sửa";

            if (dtgv.Columns["xtype"] is DataGridViewColumn col)
            {
                col.Visible = false;
            }

            if (dtgv.Columns["ma_ban"] is DataGridViewColumn col2)
            {
                col2.Visible = false;
            }
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dtgv.DataSource = GridData = DataCenter.Instance.ExecuteDataTable(Controller, "Tickets", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
            InitColumns();
        }

        void OnSellTicketClicked(object sender, EventArgs e)
        {
            var itemInput = new TicketInput();
            itemInput.Text = string.Format(itemInput.Text, "Thêm");
            itemInput.SaveClicked += OnInsert;
            itemInput.ShowDialog(this);
        }

        void OnInsert(object sender, DataSetArgs e)
        {
            if (sender is not TicketInput input) return;
            var row = DataCenter.Instance.ExecuteDataRow(Controller, "InsertTicket", e.Value, 0);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            GridData.AddCloneRow(row);
            dtgv.DataSource = GridData;

            input.Close();
        }
    }
}
