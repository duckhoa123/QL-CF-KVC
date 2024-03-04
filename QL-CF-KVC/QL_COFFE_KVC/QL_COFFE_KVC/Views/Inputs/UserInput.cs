using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class UserInput : Form
    {
        public event EventHandler<DataSetArgs> SaveClicked;

        public UserInput()
        {
            Init();
        }

        public UserInput(DataRow itemRow)
        {
            Init();
            if (itemRow == null) return;
            txtCode.Text = itemRow["id"].ToString();
            txtName.Text = itemRow["username"].ToString();
            txtFullName.Text = itemRow["full_name"].ToString();
            txtPassword.Text = itemRow["password"].ToString();
            chManager.Checked = Convert.ToBoolean(itemRow["manager"]);
            chAdmin.Checked = Convert.ToBoolean(itemRow["admin"]);
            cbStatus.SelectedValue = itemRow["trang_thai"];
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, new DataSetArgs(new DataSet().AddTable(new DataTable()
                .AddRowValue("id", string.IsNullOrEmpty(txtCode.Text) ? 0 : Convert.ToInt32(txtCode.Text), typeof(int))
                .AddRowValue("username", txtName.Text)
                .AddRowValue("full_name", txtFullName.Text)
                .AddRowValue("password", txtPassword.Text)
                .AddRowValue("manager", chManager.Checked, typeof(bool))
                .AddRowValue("admin", chAdmin.Checked, typeof(bool))
                .AddRowValue("trang_thai", cbStatus.SelectedValue))));
        }

        void Init()
        {
            InitializeComponent();
            if (UserInfo.Instance.IsAdmin)
            {
                chManager.Enabled = true;
                chAdmin.Enabled = true;
            }
            cbStatus.DataSource = StatusDataSource.Instance;
        }
    }
}
