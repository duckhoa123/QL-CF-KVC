using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class EmployeeInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public EmployeeInput()
        {
            Init();
        }

        public EmployeeInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["ma_nv"].ToString();
            txtName.Text = itemRow["ten_nv"].ToString();
            dpBirth.Value = Convert.ToDateTime(itemRow["ngay_sinh"]);
            dpStart.Value = Convert.ToDateTime(itemRow["ngay_bd"]);
            txtSalary.Text = itemRow["muc_luong"].ToString();
            cbNsd.SelectedValue = itemRow["nsd"];
            cbSex.SelectedValue = itemRow["gioi_tinh"];
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("ma_nv", txtCode.Text)
                .AddRowValue("ten_nv", txtName.Text)
                .AddRowValue("ngay_sinh", dpBirth.Value)
                .AddRowValue("ngay_bd", dpStart.Value)
                .AddRowValue("muc_luong", Convert.ToInt64(txtSalary.Text), typeof(long))
                .AddRowValue("nsd", Convert.ToInt32(cbNsd.SelectedValue), typeof(int))
                .AddRowValue("gioi_tinh", cbSex.SelectedValue)
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            txtSalary.EnableNumeric();
            cbStatus.DataSource = StatusDataSource.Instance;
            cbSex.DataSource = SexDataSource.Instance;
            cbNsd.DataSource = DataCenter.Instance.ExecuteDataTable("User", "Users", Utils.DataFromArray(new Param("trang_thai", "*")), 0);
        }
    }
}
