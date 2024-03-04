﻿
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    partial class FormQuantity
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ma_dh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_dh,
            this.ngay_lap,
            this.xtype,
            this.so_luong,
            this.trang_thai});
            this.dtgv.Location = new System.Drawing.Point(0, 96);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(800, 352);
            this.dtgv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày";
            // 
            // dpFrom
            // 
            this.dpFrom.CustomFormat = "dd/MM/yyyy";
            this.dpFrom.Location = new System.Drawing.Point(12, 27);
            this.dpFrom.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dpFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(200, 20);
            this.dpFrom.TabIndex = 28;
            this.dpFrom.Value = new System.DateTime(2022, 5, 4, 20, 10, 31, 0);
            // 
            // dpTo
            // 
            this.dpTo.CustomFormat = "dd/MM/yyyy";
            this.dpTo.Location = new System.Drawing.Point(12, 70);
            this.dpTo.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dpTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(200, 20);
            this.dpTo.TabIndex = 30;
            this.dpTo.Value = new System.DateTime(2022, 5, 4, 20, 10, 31, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Đến ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tổng số lượng:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(324, 73);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 17);
            this.lbTotal.TabIndex = 33;
            this.lbTotal.Text = "    ";
            // 
            // cbService
            // 
            this.cbService.DisplayMember = "Name";
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(250, 26);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(200, 21);
            this.cbService.TabIndex = 35;
            this.cbService.ValueMember = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Loại dịch vụ";
            // 
            // ma_dh
            // 
            this.ma_dh.DataPropertyName = "ma_dh";
            this.ma_dh.HeaderText = "Mã chứng từ";
            this.ma_dh.Name = "ma_dh";
            this.ma_dh.ReadOnly = true;
            // 
            // ngay_lap
            // 
            this.ngay_lap.DataPropertyName = "ngay_lap";
            this.ngay_lap.HeaderText = "Ngày lập";
            this.ngay_lap.Name = "ngay_lap";
            this.ngay_lap.ReadOnly = true;
            // 
            // xtype
            // 
            this.xtype.DataPropertyName = "xtype";
            this.xtype.HeaderText = "Dịch vụ";
            this.xtype.Name = "xtype";
            this.xtype.ReadOnly = true;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.Name = "so_luong";
            this.so_luong.ReadOnly = true;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // FormQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv);
            this.Name = "FormQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dtgv;
        private Label label1;
        private DateTimePicker dpFrom;
        private DateTimePicker dpTo;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label lbTotal;
        private ComboBox cbService;
        private Label label7;

        #endregion

        private DataGridViewTextBoxColumn ma_dh;
        private DataGridViewTextBoxColumn ngay_lap;
        private DataGridViewTextBoxColumn xtype;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn trang_thai;
    }
}