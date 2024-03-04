
namespace QL_COFFE_KVC
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tr_menu = new System.Windows.Forms.TreeView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tr_menu
            // 
            this.tr_menu.Location = new System.Drawing.Point(-1, 0);
            this.tr_menu.Name = "tr_menu";
            this.tr_menu.Size = new System.Drawing.Size(193, 453);
            this.tr_menu.TabIndex = 0;
            this.tr_menu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnMenuItemClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(198, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnLogoutClicked);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(198, 7);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(97, 23);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.OnChangePassClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 451);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tr_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tr_menu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePass;
    }
}