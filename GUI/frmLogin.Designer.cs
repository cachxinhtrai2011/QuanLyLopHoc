namespace GUI
{
    partial class frmLogin
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
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mttMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.mttTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.mttlab = new MetroFramework.Controls.MetroLabel();
            this.mttCheckBox = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(148, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.user_login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mttMatKhau
            // 
            // 
            // 
            // 
            this.mttMatKhau.CustomButton.Image = null;
            this.mttMatKhau.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mttMatKhau.CustomButton.Name = "";
            this.mttMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mttMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttMatKhau.CustomButton.TabIndex = 1;
            this.mttMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mttMatKhau.CustomButton.UseSelectable = true;
            this.mttMatKhau.CustomButton.Visible = false;
            this.mttMatKhau.DisplayIcon = true;
            this.mttMatKhau.Icon = global::GUI.Properties.Resources.password_icon;
            this.mttMatKhau.Lines = new string[0];
            this.mttMatKhau.Location = new System.Drawing.Point(148, 131);
            this.mttMatKhau.MaxLength = 32767;
            this.mttMatKhau.Name = "mttMatKhau";
            this.mttMatKhau.PasswordChar = '*';
            this.mttMatKhau.PromptText = "Mật Khẩu";
            this.mttMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mttMatKhau.SelectedText = "";
            this.mttMatKhau.SelectionLength = 0;
            this.mttMatKhau.SelectionStart = 0;
            this.mttMatKhau.ShortcutsEnabled = true;
            this.mttMatKhau.Size = new System.Drawing.Size(258, 23);
            this.mttMatKhau.TabIndex = 1;
            this.mttMatKhau.UseSelectable = true;
            this.mttMatKhau.WaterMark = "Mật Khẩu";
            this.mttMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mttMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mttTaiKhoan
            // 
            // 
            // 
            // 
            this.mttTaiKhoan.CustomButton.Image = null;
            this.mttTaiKhoan.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mttTaiKhoan.CustomButton.Name = "";
            this.mttTaiKhoan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mttTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttTaiKhoan.CustomButton.TabIndex = 1;
            this.mttTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mttTaiKhoan.CustomButton.UseSelectable = true;
            this.mttTaiKhoan.CustomButton.Visible = false;
            this.mttTaiKhoan.DisplayIcon = true;
            this.mttTaiKhoan.Icon = global::GUI.Properties.Resources.account_icon_login;
            this.mttTaiKhoan.Lines = new string[0];
            this.mttTaiKhoan.Location = new System.Drawing.Point(148, 80);
            this.mttTaiKhoan.MaxLength = 32767;
            this.mttTaiKhoan.Name = "mttTaiKhoan";
            this.mttTaiKhoan.PasswordChar = '\0';
            this.mttTaiKhoan.PromptText = "Tài Khoản";
            this.mttTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mttTaiKhoan.SelectedText = "";
            this.mttTaiKhoan.SelectionLength = 0;
            this.mttTaiKhoan.SelectionStart = 0;
            this.mttTaiKhoan.ShortcutsEnabled = true;
            this.mttTaiKhoan.Size = new System.Drawing.Size(258, 23);
            this.mttTaiKhoan.TabIndex = 0;
            this.mttTaiKhoan.UseSelectable = true;
            this.mttTaiKhoan.WaterMark = "Tài Khoản";
            this.mttTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mttTaiKhoan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mttlab
            // 
            this.mttlab.AutoSize = true;
            this.mttlab.ForeColor = System.Drawing.Color.Red;
            this.mttlab.Location = new System.Drawing.Point(175, 214);
            this.mttlab.Name = "mttlab";
            this.mttlab.Size = new System.Drawing.Size(0, 0);
            this.mttlab.TabIndex = 5;
            this.mttlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mttlab.UseCustomForeColor = true;
            this.mttlab.Visible = false;
            // 
            // mttCheckBox
            // 
            this.mttCheckBox.AutoSize = true;
            this.mttCheckBox.Location = new System.Drawing.Point(268, 185);
            this.mttCheckBox.Name = "mttCheckBox";
            this.mttCheckBox.Size = new System.Drawing.Size(120, 15);
            this.mttCheckBox.TabIndex = 3;
            this.mttCheckBox.Text = "Nhớ tài khoản này";
            this.mttCheckBox.UseSelectable = true;
            this.mttCheckBox.CheckedChanged += new System.EventHandler(this.mttCheckBox_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 253);
            this.Controls.Add(this.mttCheckBox);
            this.Controls.Add(this.mttlab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.mttMatKhau);
            this.Controls.Add(this.mttTaiKhoan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mttTaiKhoan;
        private MetroFramework.Controls.MetroTextBox mttMatKhau;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mttlab;
        private MetroFramework.Controls.MetroCheckBox mttCheckBox;
    }
}