
namespace QL_COFFE_KVC
{
    partial class FormBookReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ma_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_loai_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da_the = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(319, 70);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 17);
            this.lbTotal.TabIndex = 43;
            this.lbTotal.Text = "    ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 23);
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
            this.ma_sach,
            this.ten_sach,
            this.ma_loai_sach,
            this.da_the,
            this.trang_thai});
            this.dtgv.Location = new System.Drawing.Point(0, 92);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(668, 352);
            this.dtgv.TabIndex = 36;
            // 
            // cbBookType
            // 
            this.cbBookType.DisplayMember = "ten_loai_sach";
            this.cbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Location = new System.Drawing.Point(231, 22);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(231, 21);
            this.cbBookType.TabIndex = 49;
            this.cbBookType.ValueMember = "ma_loai_sach";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Loại sách";
            // 
            // ma_sach
            // 
            this.ma_sach.DataPropertyName = "ma_sach";
            this.ma_sach.HeaderText = "Mã sách";
            this.ma_sach.Name = "ma_sach";
            this.ma_sach.ReadOnly = true;
            // 
            // ten_sach
            // 
            this.ten_sach.DataPropertyName = "ten_sach";
            this.ten_sach.FillWeight = 120F;
            this.ten_sach.HeaderText = "Tên sách";
            this.ten_sach.Name = "ten_sach";
            this.ten_sach.ReadOnly = true;
            this.ten_sach.Width = 150;
            // 
            // ma_loai_sach
            // 
            this.ma_loai_sach.DataPropertyName = "ma_loai_sach";
            this.ma_loai_sach.HeaderText = "Loại sách";
            this.ma_loai_sach.Name = "ma_loai_sach";
            this.ma_loai_sach.ReadOnly = true;
            this.ma_loai_sach.Width = 150;
            // 
            // da_the
            // 
            this.da_the.DataPropertyName = "da_thue";
            this.da_the.HeaderText = "Số lượng đã thuê";
            this.da_the.Name = "da_the";
            this.da_the.ReadOnly = true;
            this.da_the.Width = 125;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // FormBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.cbBookType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv);
            this.Name = "FormBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tình trạng sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_loai_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn da_the;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
    }
}