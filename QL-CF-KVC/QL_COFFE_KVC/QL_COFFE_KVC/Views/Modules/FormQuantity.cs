using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class FormQuantity : Form
    {
        public FormQuantity()
        {
            InitializeComponent();
            cbService.DataSource = ServiceDataSource.Instance;
            cbService.SelectedValue = "*";
            dpFrom.Value = DateTime.Now.AddDays(-30);
            dpTo.Value = DateTime.Now;
            LoadData();
        }

        void LoadData()
        {
            var ds = new DataSet();
            ds.AddTable(new DataTable().AddRowValue("from_date", dpFrom.Value, typeof(DateTime))
                .AddRowValue("to_date", dpTo.Value, typeof(DateTime))
                .AddRowValue("xtype", cbService.SelectedValue));
            ds = DataCenter.Instance.ExecuteDataSet("Quantity", "Filter", ds, 0);
            dtgv.DataSource = ds.Tables[0];

            var sum = ds.Tables[1].Rows[0]["so_luong"];
            if (sum == DBNull.Value) sum = 0;
            lbTotal.Text = Convert.ToInt64(sum).ToString("n0");
        }

        void OnFilterClicked(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}