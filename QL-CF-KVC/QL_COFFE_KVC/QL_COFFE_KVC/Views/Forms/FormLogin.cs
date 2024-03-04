using System;
using System.Data;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class FormLogin : Form
    {
        public event EventHandler LoginSuccess;
        public FormLogin()
        {
            InitializeComponent();

#if DEBUG
            txtUsername.Text = "ADMIN";
            txtPassword.Text = "2";
#endif
        }

        void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                var userRow = DataCenter.Instance.Login(txtUsername.Text, txtPassword.Text);
                if (userRow == null)
                {
                    Alert.Instance.ShowAlert("Thông tin đăng nhập không đúng", Text);
                    return;
                }

                UserInfo.FromRow(userRow);
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Alert.Instance.ShowAlert(ex.Message, Text);
            }
        }
    }
}
