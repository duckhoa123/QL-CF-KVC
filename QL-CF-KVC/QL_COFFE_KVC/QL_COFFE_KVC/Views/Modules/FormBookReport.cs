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
    public partial class FormBookReport : Form
    {
        public FormBookReport()
        {
            InitializeComponent();
            dpFrom.Value = DateTime.Now.AddDays(-30);
            dpTo.Value = DateTime.Now;
            cbBookType.DataSource = FormatBookType(DataCenter.Instance.ExecuteDataTable("BookType", "BookTypes", Utils.DataFromArray(new Param("trang_thai", "*")), 0));
            LoadData();
        }

        void LoadData()
        {
            var ds = new DataSet();
            ds.AddTable(new DataTable().AddRowValue("from_date", dpFrom.Value, typeof(DateTime))
                .AddRowValue("to_date", dpTo.Value, typeof(DateTime))
                .AddRowValue("ma_loai_sach", cbBookType.SelectedValue));
            ds = DataCenter.Instance.ExecuteDataSet("BookReport", "Filter", ds, 0);
            dtgv.DataSource = ds.Tables[0];

        }

        void OnFilterClicked(object sender, EventArgs e)
        {
            LoadData();
        }

        DataTable FormatBookType(DataTable table)
        {
            var row = table.NewRow();
            row["ma_loai_sach"] = "*";
            row["ten_loai_sach"] = "Tất cả loại";
            table.Rows.InsertAt(row, 0);
            return table;
        }
    }
}
