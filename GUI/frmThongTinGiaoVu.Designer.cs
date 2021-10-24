namespace GUI
{
    partial class frmThongTinGiaoVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinGiaoVu));
            this.txtTenGiaovu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThuchienThemhocsinh = new DevExpress.XtraEditors.SimpleButton();
            this.lblcomfirmPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtComfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenGiaovu
            // 
            this.txtTenGiaovu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiaovu.Location = new System.Drawing.Point(135, 29);
            this.txtTenGiaovu.MaxLength = 255;
            this.txtTenGiaovu.Name = "txtTenGiaovu";
            this.txtTenGiaovu.Size = new System.Drawing.Size(328, 25);
            this.txtTenGiaovu.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(135, 66);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(135, 103);
            this.txtSDT.MaxLength = 16;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(328, 25);
            this.txtSDT.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(133, 140);
            this.txtTaiKhoan.MaxLength = 255;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(330, 25);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên giáo vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = global::GUI.Properties.Resources.update_Thongtin_GiaoVu_icon;
            this.btnUpdate.Location = new System.Drawing.Point(371, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnThuchienThemhocsinh
            // 
            this.btnThuchienThemhocsinh.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchienThemhocsinh.Appearance.Options.UseFont = true;
            this.btnThuchienThemhocsinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThuchienThemhocsinh.ImageOptions.Image")));
            this.btnThuchienThemhocsinh.Location = new System.Drawing.Point(236, 259);
            this.btnThuchienThemhocsinh.Name = "btnThuchienThemhocsinh";
            this.btnThuchienThemhocsinh.Size = new System.Drawing.Size(92, 40);
            this.btnThuchienThemhocsinh.TabIndex = 6;
            this.btnThuchienThemhocsinh.Text = "Thêm";
            this.btnThuchienThemhocsinh.Click += new System.EventHandler(this.btnThuchienThemhocsinh_Click);
            // 
            // lblcomfirmPassword
            // 
            this.lblcomfirmPassword.AutoSize = true;
            this.lblcomfirmPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomfirmPassword.Location = new System.Drawing.Point(12, 218);
            this.lblcomfirmPassword.Name = "lblcomfirmPassword";
            this.lblcomfirmPassword.Size = new System.Drawing.Size(109, 17);
            this.lblcomfirmPassword.TabIndex = 4;
            this.lblcomfirmPassword.Text = "Xác nhân lại MK";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(53, 181);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(68, 17);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Mật Khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(133, 177);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtComfirm
            // 
            this.txtComfirm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComfirm.Location = new System.Drawing.Point(133, 214);
            this.txtComfirm.MaxLength = 255;
            this.txtComfirm.Name = "txtComfirm";
            this.txtComfirm.Size = new System.Drawing.Size(328, 25);
            this.txtComfirm.TabIndex = 5;
            this.txtComfirm.UseSystemPasswordChar = true;
            // 
            // frmThongTinGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 333);
            this.Controls.Add(this.btnThuchienThemhocsinh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lblcomfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenGiaovu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinGiaoVu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin giáo vụ";
            this.Load += new System.EventHandler(this.frmThongTinGiaoVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenGiaovu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public DevExpress.XtraEditors.SimpleButton btnUpdate;
        public DevExpress.XtraEditors.SimpleButton btnThuchienThemhocsinh;
        public System.Windows.Forms.Label lbPassword;
        public System.Windows.Forms.Label lblcomfirmPassword;
        public System.Windows.Forms.TextBox txtComfirm;
        public System.Windows.Forms.TextBox txtPassword;
    }
}