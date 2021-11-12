namespace GUI
{
    partial class frmCapNhatHocSinh
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtTenChaMe = new System.Windows.Forms.TextBox();
            this.txtSDTLienHe = new System.Windows.Forms.TextBox();
            this.cbLopHC = new System.Windows.Forms.ComboBox();
            this.lbLopHc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHS = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Cha Mẹ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT Liên hệ";
            // 
            // datNgaySinh
            // 
            this.datNgaySinh.Location = new System.Drawing.Point(125, 96);
            this.datNgaySinh.Name = "datNgaySinh";
            this.datNgaySinh.Size = new System.Drawing.Size(161, 21);
            this.datNgaySinh.TabIndex = 1;
            this.datNgaySinh.ValueChanged += new System.EventHandler(this.datNgaySinh_ValueChanged);
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(125, 57);
            this.txtTenHS.MaxLength = 255;
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(446, 21);
            this.txtTenHS.TabIndex = 0;
            // 
            // txtTenChaMe
            // 
            this.txtTenChaMe.Location = new System.Drawing.Point(125, 132);
            this.txtTenChaMe.MaxLength = 255;
            this.txtTenChaMe.Name = "txtTenChaMe";
            this.txtTenChaMe.Size = new System.Drawing.Size(446, 21);
            this.txtTenChaMe.TabIndex = 1;
            // 
            // txtSDTLienHe
            // 
            this.txtSDTLienHe.Location = new System.Drawing.Point(125, 169);
            this.txtSDTLienHe.MaxLength = 10;
            this.txtSDTLienHe.Name = "txtSDTLienHe";
            this.txtSDTLienHe.Size = new System.Drawing.Size(446, 21);
            this.txtSDTLienHe.TabIndex = 2;
            // 
            // cbLopHC
            // 
            this.cbLopHC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLopHC.FormattingEnabled = true;
            this.cbLopHC.Location = new System.Drawing.Point(125, 236);
            this.cbLopHC.Name = "cbLopHC";
            this.cbLopHC.Size = new System.Drawing.Size(121, 21);
            this.cbLopHC.TabIndex = 4;
            // 
            // lbLopHc
            // 
            this.lbLopHc.AutoSize = true;
            this.lbLopHc.Location = new System.Drawing.Point(26, 239);
            this.lbLopHc.Name = "lbLopHc";
            this.lbLopHc.Size = new System.Drawing.Size(82, 13);
            this.lbLopHc.TabIndex = 9;
            this.lbLopHc.Text = "Lớp Hành Chính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(125, 205);
            this.txtDiaChi.MaxLength = 255;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(446, 21);
            this.txtDiaChi.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = global::GUI.Properties.Resources.update_member_icon;
            this.btnUpdate.Location = new System.Drawing.Point(171, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 49);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật HS";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThemHS
            // 
            this.btnThemHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemHS.Enabled = false;
            this.btnThemHS.ImageOptions.Image = global::GUI.Properties.Resources.add_32x321;
            this.btnThemHS.Location = new System.Drawing.Point(376, 281);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(105, 49);
            this.btnThemHS.TabIndex = 6;
            this.btnThemHS.Text = "Thêm HS";
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCapNhatHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 342);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemHS);
            this.Controls.Add(this.lbLopHc);
            this.Controls.Add(this.cbLopHC);
            this.Controls.Add(this.txtSDTLienHe);
            this.Controls.Add(this.txtTenChaMe);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.datNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatHocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Học Sinh";
            this.Load += new System.EventHandler(this.frmCapNhatHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLopHc;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.SimpleButton btnUpdate;
        public DevExpress.XtraEditors.SimpleButton btnThemHS;
        public System.Windows.Forms.DateTimePicker datNgaySinh;
        public System.Windows.Forms.TextBox txtTenHS;
        public System.Windows.Forms.TextBox txtTenChaMe;
        public System.Windows.Forms.TextBox txtSDTLienHe;
        public System.Windows.Forms.ComboBox cbLopHC;
        public System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}