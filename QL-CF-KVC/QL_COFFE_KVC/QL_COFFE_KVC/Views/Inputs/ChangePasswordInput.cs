using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class ChangePasswordInput : Form
    {
        public ChangePasswordInput()
        {
            InitializeComponent();
        }

        void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOld.Text) || string.IsNullOrEmpty(txtNew.Text))
            {
                Alert.Instance.ShowAlert("Mật khẩu không được để trống.", Text);
                return;
            }

            if (txtNew.Text != txtReNew.Text)
            {
                Alert.Instance.ShowAlert("Xác nhận mật khẩu không đúng.", Text);
                return;
            }

            var ds = new DataSet().AddTable(new DataTable()
                .AddRowValue("old_pass", txtOld.Text)
                .AddRowValue("new_pass", txtNew.Text));

            var row = DataCenter.Instance.ExecuteDataRow("System", "ChangePassword", ds, 0);
            if (row == null)
                return;

            if (row.Table.Columns.Contains("message") && !string.IsNullOrEmpty(row["message"].ToString()))
            {
                Alert.Instance.ShowAlert(row["message"].ToString(), Text);
                return;
            }

            Close();
        }
    }
}
