
namespace QL_COFFE_KVC
{
    partial class FormSite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ( )
        {
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.ma_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mo_ta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNcc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(538, 69);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 17);
            this.lbTotal.TabIndex = 43;
            this.lbTotal.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Số lượng tồn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // dpTo
            // 
            this.dpTo.CustomFormat = "dd/MM/yyyy";
            this.dpTo.Location = new System.Drawing.Point(12, 66);
            this.dpTo.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dpTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(200, 20);
            this.dpTo.TabIndex = 40;
            this.dpTo.Value = new System.DateTime(2022, 5, 4, 20, 10, 31, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Đến ngày";
            // 
            // dpFrom
            // 
            this.dpFrom.CustomFormat = "dd/MM/yyyy";
            this.dpFrom.Location = new System.Drawing.Point(12, 23);
            this.dpFrom.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dpFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(200, 20);
            this.dpFrom.TabIndex = 38;
            this.dpFrom.Value = new System.DateTime(2022, 5, 4, 20, 10, 31, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Từ ngày";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_vt,
            this.ten_vt,
            this.mo_ta,
            this.sl_ton,
            this.gia_ban,
            this.ma_ncc,
            this.trang_thai});
            this.dtgv.Location = new System.Drawing.Point(0, 92);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(800, 352);
            this.dtgv.TabIndex = 36;
            // 
            // ma_vt
            // 
            this.ma_vt.DataPropertyName = "ma_vt";
            this.ma_vt.HeaderText = "Mã vật tư";
            this.ma_vt.Name = "ma_vt";
            this.ma_vt.ReadOnly = true;
            // 
            // ten_vt
            // 
            this.ten_vt.DataPropertyName = "ten_vt";
            this.ten_vt.FillWeight = 120F;
            this.ten_vt.HeaderText = "Tên vật tư";
            this.ten_vt.Name = "ten_vt";
            this.ten_vt.ReadOnly = true;
            // 
            // mo_ta
            // 
            this.mo_ta.DataPropertyName = "mo_ta";
            this.mo_ta.HeaderText = "Mô tả";
            this.mo_ta.Name = "mo_ta";
            this.mo_ta.ReadOnly = true;
            this.mo_ta.Width = 150;
            // 
            // sl_ton
            // 
            this.sl_ton.DataPropertyName = "sl_ton";
            this.sl_ton.HeaderText = "Số lượng tồn";
            this.sl_ton.Name = "sl_ton";
            this.sl_ton.ReadOnly = true;
            // 
            // gia_ban
            // 
            this.gia_ban.DataPropertyName = "gia_ban";
            this.gia_ban.HeaderText = "Giá bán";
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.ReadOnly = true;
            // 
            // ma_ncc
            // 
            this.ma_ncc.DataPropertyName = "ma_ncc";
            this.ma_ncc.HeaderText = "Mã nhà cung cấp";
            this.ma_ncc.Name = "ma_ncc";
            this.ma_ncc.ReadOnly = true;
            this.ma_ncc.Width = 125;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "Name";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(468, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(225, 21);
            this.cbStatus.TabIndex = 47;
            this.cbStatus.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Trạng thái";
            // 
            // cbNcc
            // 
            this.cbNcc.DisplayMember = "ten_ncc";
            this.cbNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNcc.FormattingEnabled = true;
            this.cbNcc.Location = new System.Drawing.Point(231, 22);
            this.cbNcc.Name = "cbNcc";
            this.cbNcc.Size = new System.Drawing.Size(231, 21);
            this.cbNcc.TabIndex = 49;
            this.cbNcc.ValueMember = "ma_ncc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nhà cung cấp";
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "Name";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(231, 64);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(225, 21);
            this.cbType.TabIndex = 51;
            this.cbType.ValueMember = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Loại báo cáo";
            // 
            // FormSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNcc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv);
            this.Name = "FormSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn kho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mo_ta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_ton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
    }
}