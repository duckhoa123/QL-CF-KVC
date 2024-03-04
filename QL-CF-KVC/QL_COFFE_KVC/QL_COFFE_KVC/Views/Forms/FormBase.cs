using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC.Forms
{
    public partial class FormBase : Form
    {
        protected DataGridView GridView { get => dtgv; }
        protected virtual string Controller { get; }
        protected DataTable ViewGrid { get; set; }

        public FormBase()
        {
            InitializeComponent();
            LoadData();
            InitColumns();
        }

        protected virtual void LoadData()
        {

        }

        protected virtual void InitColumns()
        {

        }

        protected virtual void OnNewClicked(object sender, EventArgs e)
        {

        }

        protected virtual void OnEditClicked(object sender, EventArgs e)
        {

        }

        protected virtual void OnDeleteClicked(object sender, EventArgs e)
        {

        }

        protected DataGridViewRow GetSelectionRow()
        {
            return dtgv.SelectedRows.Count > 0 ? dtgv.SelectedRows[0] : null;
        }

        protected void SetDataSource(object sources)
        {
            dtgv.DataSource = sources;
        }

        protected virtual void OnSearchChanged(object sender, EventArgs e)
        {
            var data = GetSearchFilter();
            var table = DataCenter.Instance.ExecuteDataTable(Controller, "Search", data, 0);
            if (table == null) return;
            ViewGrid = table;
            SetDataSource(ViewGrid);
        }

        protected virtual DataSet GetSearchFilter()
        {
            return Utils.DataFromArray(new Param("trang_thai", "*"), new Param("search_text", txtSearch.Text));
        }

        void OnRemoveClicked(object sender, EventArgs e)
        {
            if (GetSelectionRow() is not DataGridViewRow) return;
            if (Alert.Instance.ShowAlert("Bạn có chắc chắn muốn xóa bản ghi này không?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            OnDeleteClicked(sender, e);
        }
    }
}
