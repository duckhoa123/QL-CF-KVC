
namespace QL_COFFE_KVC
{
    partial class CheckInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rNote = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.gvDetail = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQty4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPoor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFull = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ma_ph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_tien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_tien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_tien3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_tien4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loss_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Mã phiếu";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(12, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(319, 20);
            this.txtCode.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "Name";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(363, 611);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(320, 21);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.ValueMember = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trạng thái";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(606, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSaveClicked);
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(13, 375);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.ReadOnly = true;
            this.txtQty1.Size = new System.Drawing.Size(318, 20);
            this.txtQty1.TabIndex = 18;
            this.txtQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng kế toán";
            // 
            // dpDate
            // 
            this.dpDate.CustomFormat = "dd/MM/yyyy";
            this.dpDate.Location = new System.Drawing.Point(360, 39);
            this.dpDate.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(200, 20);
            this.dpDate.TabIndex = 29;
            this.dpDate.Value = new System.DateTime(2022, 4, 25, 0, 13, 17, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày lập";
            // 
            // rNote
            // 
            this.rNote.Location = new System.Drawing.Point(12, 84);
            this.rNote.Name = "rNote";
            this.rNote.Size = new System.Drawing.Size(664, 56);
            this.rNote.TabIndex = 31;
            this.rNote.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ghi chú";
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNew.Location = new System.Drawing.Point(391, 328);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 23);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "Thêm dòng";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.OnNewClicked);
            // 
            // gvDetail
            // 
            this.gvDetail.BackgroundColor = System.Drawing.Color.White;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_ph,
            this.stt,
            this.ma_vt,
            this.so_luong1,
            this.tong_tien1,
            this.so_luong2,
            this.tong_tien2,
            this.so_luong3,
            this.tong_tien3,
            this.so_luong4,
            this.tong_tien4,
            this.full_quality,
            this.poor_quality,
            this.loss_quality});
            this.gvDetail.GridColor = System.Drawing.SystemColors.Control;
            this.gvDetail.Location = new System.Drawing.Point(12, 166);
            this.gvDetail.MultiSelect = false;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.ReadOnly = true;
            this.gvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetail.Size = new System.Drawing.Size(664, 147);
            this.gvDetail.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Chi tiết";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(488, 328);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 23);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa dòng";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.OnEditClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(585, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xóa dòng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClicked);
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(360, 375);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.ReadOnly = true;
            this.txtTotal1.Size = new System.Drawing.Size(318, 20);
            this.txtTotal1.TabIndex = 46;
            this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tổng tiền kế toán";
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(360, 422);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(318, 20);
            this.txtTotal2.TabIndex = 50;
            this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tổng tiền kiểm kê";
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(13, 422);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.ReadOnly = true;
            this.txtQty2.Size = new System.Drawing.Size(318, 20);
            this.txtQty2.TabIndex = 48;
            this.txtQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Số lượng kiểm kê";
            // 
            // txtTotal3
            // 
            this.txtTotal3.Location = new System.Drawing.Point(360, 469);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.ReadOnly = true;
            this.txtTotal3.Size = new System.Drawing.Size(318, 20);
            this.txtTotal3.TabIndex = 54;
            this.txtTotal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Tổng tiền thừa";
            // 
            // txtQty3
            // 
            this.txtQty3.Location = new System.Drawing.Point(13, 469);
            this.txtQty3.Name = "txtQty3";
            this.txtQty3.ReadOnly = true;
            this.txtQty3.Size = new System.Drawing.Size(318, 20);
            this.txtQty3.TabIndex = 52;
            this.txtQty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Số lượng thừa";
            // 
            // txtTotal4
            // 
            this.txtTotal4.Location = new System.Drawing.Point(361, 518);
            this.txtTotal4.Name = "txtTotal4";
            this.txtTotal4.ReadOnly = true;
            this.txtTotal4.Size = new System.Drawing.Size(318, 20);
            this.txtTotal4.TabIndex = 58;
            this.txtTotal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Tổng tiền thiếu";
            // 
            // txtQty4
            // 
            this.txtQty4.Location = new System.Drawing.Point(14, 518);
            this.txtQty4.Name = "txtQty4";
            this.txtQty4.ReadOnly = true;
            this.txtQty4.Size = new System.Drawing.Size(318, 20);
            this.txtQty4.TabIndex = 56;
            this.txtQty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 501);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Số lượng thiếu";
            // 
            // txtPoor
            // 
            this.txtPoor.Location = new System.Drawing.Point(363, 565);
            this.txtPoor.Name = "txtPoor";
            this.txtPoor.ReadOnly = true;
            this.txtPoor.Size = new System.Drawing.Size(318, 20);
            this.txtPoor.TabIndex = 62;
            this.txtPoor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 548);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "SL kém phẩm chất";
            // 
            // txtFull
            // 
            this.txtFull.Location = new System.Drawing.Point(16, 565);
            this.txtFull.Name = "txtFull";
            this.txtFull.ReadOnly = true;
            this.txtFull.Size = new System.Drawing.Size(318, 20);
            this.txtFull.TabIndex = 60;
            this.txtFull.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "SL Tốt 100%";
            // 
            // txtLoss
            // 
            this.txtLoss.Location = new System.Drawing.Point(16, 612);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.ReadOnly = true;
            this.txtLoss.Size = new System.Drawing.Size(318, 20);
            this.txtLoss.TabIndex = 64;
            this.txtLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "SL mất phẩm chất";
            // 
            // ma_ph
            // 
            this.ma_ph.DataPropertyName = "ma_ph";
            this.ma_ph.HeaderText = "Mã Phiếu";
            this.ma_ph.Name = "ma_ph";
            this.ma_ph.ReadOnly = true;
            this.ma_ph.Visible = false;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // ma_vt
            // 
            this.ma_vt.DataPropertyName = "ma_vt";
            this.ma_vt.HeaderText = "Mã vật tư";
            this.ma_vt.Name = "ma_vt";
            this.ma_vt.ReadOnly = true;
            // 
            // so_luong1
            // 
            this.so_luong1.DataPropertyName = "so_luong1";
            this.so_luong1.HeaderText = "Số lượng kế toán";
            this.so_luong1.Name = "so_luong1";
            this.so_luong1.ReadOnly = true;
            // 
            // tong_tien1
            // 
            this.tong_tien1.DataPropertyName = "tong_tien1";
            this.tong_tien1.HeaderText = "Tổng tiền kế toán";
            this.tong_tien1.Name = "tong_tien1";
            this.tong_tien1.ReadOnly = true;
            // 
            // so_luong2
            // 
            this.so_luong2.DataPropertyName = "so_luong2";
            this.so_luong2.HeaderText = "Số lượng kiểm kê";
            this.so_luong2.Name = "so_luong2";
            this.so_luong2.ReadOnly = true;
            // 
            // tong_tien2
            // 
            this.tong_tien2.DataPropertyName = "tong_tien2";
            this.tong_tien2.HeaderText = "Tổng tiền kiểm kê";
            this.tong_tien2.Name = "tong_tien2";
            this.tong_tien2.ReadOnly = true;
            // 
            // so_luong3
            // 
            this.so_luong3.DataPropertyName = "so_luong3";
            this.so_luong3.HeaderText = "Số lượng thừa";
            this.so_luong3.Name = "so_luong3";
            this.so_luong3.ReadOnly = true;
            // 
            // tong_tien3
            // 
            this.tong_tien3.DataPropertyName = "tong_tien3";
            this.tong_tien3.HeaderText = "Tổng tiền thừa";
            this.tong_tien3.Name = "tong_tien3";
            this.tong_tien3.ReadOnly = true;
            // 
            // so_luong4
            // 
            this.so_luong4.DataPropertyName = "so_luong4";
            this.so_luong4.HeaderText = "Số lượng thiếu";
            this.so_luong4.Name = "so_luong4";
            this.so_luong4.ReadOnly = true;
            // 
            // tong_tien4
            // 
            this.tong_tien4.DataPropertyName = "tong_tien4";
            this.tong_tien4.HeaderText = "Tổng tiền thiếu";
            this.tong_tien4.Name = "tong_tien4";
            this.tong_tien4.ReadOnly = true;
            // 
            // full_quality
            // 
            this.full_quality.DataPropertyName = "full_quality";
            this.full_quality.HeaderText = "SL Tốt 100%";
            this.full_quality.Name = "full_quality";
            this.full_quality.ReadOnly = true;
            // 
            // poor_quality
            // 
            this.poor_quality.DataPropertyName = "poor_quality";
            this.poor_quality.HeaderText = "SL Kém phẩm chất";
            this.poor_quality.Name = "poor_quality";
            this.poor_quality.ReadOnly = true;
            // 
            // loss_quality
            // 
            this.loss_quality.DataPropertyName = "loss_quality";
            this.loss_quality.HeaderText = "SL Mất phẩm chất";
            this.loss_quality.Name = "loss_quality";
            this.loss_quality.ReadOnly = true;
            // 
            // CheckInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 669);
            this.Controls.Add(this.txtLoss);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPoor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotal4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQty4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotal3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQty3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gvDetail);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{0} nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView gvDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQty4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPoor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLoss;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ph;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_tien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_tien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_tien3;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_tien4;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn poor_quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn loss_quality;
    }
}