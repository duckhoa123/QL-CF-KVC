using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public partial class FormMain : Form
    {
        FormLogin frmLogin;
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Hide();
            frmLogin = new FormLogin();
            frmLogin.LoginSuccess += OnLoginSuccess;
            frmLogin.ShowDialog();
        }

        void OnLoginSuccess(object sender, EventArgs e)
        {
            frmLogin.Close();
            frmLogin = null;
            Show();
            InitMenu();
            ReShow();
        }

        void OnLogoutClicked(object sender, EventArgs e)
        {
            Hide();
            frmLogin = new FormLogin();
            frmLogin.LoginSuccess += OnLoginSuccess;
            Clear();
            frmLogin.ShowDialog();
        }

        void InitMenu()
        {
            tr_menu.BeginUpdate();
            var cNode = tr_menu.Nodes.Add("Danh mục");
            cNode.Nodes.Add("FormProviders", "Danh mục nhà cung cấp");

            cNode = tr_menu.Nodes.Add("Quản lý Coffe");
            cNode.Nodes.Add("FormItems", "Danh mục sản phẩm");
            cNode.Nodes.Add("FormMaterials", "Danh mục nguyên vật liệu");
            cNode.Nodes.Add("FormOrders", "Lập hóa đơn");
            cNode.Nodes.Add("FormTables", "Danh mục bàn");

            cNode = tr_menu.Nodes.Add("Quản lý khu vui chơi");
            cNode.Nodes.Add("FormTickets", "Bán vé");
            cNode.Nodes.Add("FormPlaces", "Danh mục khu");

            cNode = tr_menu.Nodes.Add("Quản lý khu đọc sách");
            cNode.Nodes.Add("FormBooks", "Danh mục sách");
            cNode.Nodes.Add("FormBookTypes", "Loại sách");
            cNode.Nodes.Add("FormRentBook", "Phiếu thuê sách");
            cNode.Nodes.Add("FormBookReport", "Báo cáo tình trạng sách");

            cNode = tr_menu.Nodes.Add("Chứng từ");
            cNode.Nodes.Add("FormChecks", "Phiếu kiểm kê");
            cNode.Nodes.Add("FormBrokens", "Phiếu báo hỏng");

            if (UserInfo.Instance.IsManager)
            {
                var mNode = tr_menu.Nodes.Add("Báo cáo");
                mNode.Nodes.Add("FormRevenue", "Báo cáo doanh thu");
                mNode.Nodes.Add("FormSite", "Báo cáo sản phẩm");
                mNode.Nodes.Add("FormQuantity", "Báo cáo sản lượng");
            }

            if (UserInfo.Instance.IsAdmin || UserInfo.Instance.IsManager)
            {
                var aNode = tr_menu.Nodes.Add("Hệ thống");
                aNode.Nodes.Add("FormEmployees", "Danh mục nhân viên");
                if (UserInfo.Instance.IsAdmin)
                {
                    aNode.Nodes.Add("FormUsers", "Danh mục người sử dụng");
                }
            }

            tr_menu.EndUpdate();
        }

        void OnMenuItemClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = e.Node;
            ShowForm(selectedNode.Name, selectedNode.Text);
        }

        void Clear()
        {
            tr_menu.Nodes.Clear();
            tr_menu.Hide();
            btnLogout.Hide();
        }

        void ReShow()
        {
            tr_menu.Show();
            btnLogout.Show();
        }

        void ShowForm(string id, string text)
        {
            var assembly = Assembly.Load("QL_COFFE_KVC");
            if (assembly == null) return;
            var classType = assembly.GetTypes().FirstOrDefault(t => t.Name == id);
            if (classType == null) return;
            var instance = Activator.CreateInstance(classType);
            if (instance is Form form)
            {
                form.Text = text;
                form.ShowDialog();
            }
        }

        void OnChangePassClicked(object sender, EventArgs e)
        {
            var form = new ChangePasswordInput();
            form.ShowDialog();
        }
    }
}
