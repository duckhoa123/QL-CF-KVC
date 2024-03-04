using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class FormSite : Form
    {
        public FormSite()
        {
            InitializeComponent();
            dpFrom.Value = DateTime.Now.AddDays(-30);
            dpTo.Value = DateTime.Now;
            var source = new List<Param>(StatusDataSource.Instance.GetRange(0, StatusDataSource.Instance.Count));

            source.Insert(0, new Param("Tất cả", "*"));
            cbStatus.DataSource = source;
            cbNcc.DataSource = FormatProviders(DataCenter.Instance.ExecuteDataTable("Provider", "Providers", Utils.DataFromArray(new Param("trang_thai", "*")), 0));
            cbType.DataSource = SiteReportFilter.Instance;
            LoadData();
        }

        void LoadData()
        {
            var ds = new DataSet();
            ds.AddTable(new DataTable().AddRowValue("from_date", dpFrom.Value, typeof(DateTime))
                .AddRowValue("to_date", dpTo.Value, typeof(DateTime))
                .AddRowValue("ma_ncc", cbNcc.SelectedValue)
                .AddRowValue("type", cbType.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue));
            ds = DataCenter.Instance.ExecuteDataSet("Site", "Filter", ds, 0);
            dtgv.DataSource = ds.Tables[0];

            var sumInventory = ds.Tables[1].Rows[0]["sl_ton"];
            if (sumInventory == DBNull.Value) sumInventory = 0;
            lbTotal.Text = Convert.ToInt64(sumInventory).ToString("n0");
        }

        void OnFilterClicked(object sender, EventArgs e)
        {
            LoadData();
        }

        DataTable FormatProviders(DataTable table)
        {
            if (table == null) return null;
            var row = table.NewRow();
            row["ma_ncc"] = "*";
            row["ten_ncc"] = "Tất cả";
            table.Rows.InsertAt(row, 0);
            return table;
        }
    }
}
