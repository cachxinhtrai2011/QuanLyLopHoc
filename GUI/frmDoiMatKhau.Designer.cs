namespace GUI
{
    partial class frmDoiMatKhau
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
            this.lblPasswordCu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordCu = new System.Windows.Forms.TextBox();
            this.txtPassWordMoi = new System.Windows.Forms.TextBox();
            this.txtComFirm = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblPasswordCu
            // 
            this.lblPasswordCu.AutoSize = true;
            this.lblPasswordCu.Location = new System.Drawing.Point(48, 13);
            this.lblPasswordCu.Name = "lblPasswordCu";
            this.lblPasswordCu.Size = new System.Drawing.Size(66, 13);
            this.lblPasswordCu.TabIndex = 0;
            this.lblPasswordCu.Text = "Mật Khẩu cũ";
            this.lblPasswordCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác Nhận";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPasswordCu
            // 
            this.txtPasswordCu.Location = new System.Drawing.Point(133, 10);
            this.txtPasswordCu.Name = "txtPasswordCu";
            this.txtPasswordCu.PasswordChar = '*';
            this.txtPasswordCu.Size = new System.Drawing.Size(230, 21);
            this.txtPasswordCu.TabIndex = 0;
            this.txtPasswordCu.UseSystemPasswordChar = true;
            // 
            // txtPassWordMoi
            // 
            this.txtPassWordMoi.Location = new System.Drawing.Point(133, 47);
            this.txtPassWordMoi.Name = "txtPassWordMoi";
            this.txtPassWordMoi.PasswordChar = '*';
            this.txtPassWordMoi.Size = new System.Drawing.Size(230, 21);
            this.txtPassWordMoi.TabIndex = 1;
            this.txtPassWordMoi.UseSystemPasswordChar = true;
            // 
            // txtComFirm
            // 
            this.txtComFirm.Location = new System.Drawing.Point(133, 84);
            this.txtComFirm.Name = "txtComFirm";
            this.txtComFirm.PasswordChar = '*';
            this.txtComFirm.Size = new System.Drawing.Size(230, 21);
            this.txtComFirm.TabIndex = 2;
            this.txtComFirm.UseSystemPasswordChar = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.ImageOptions.Image = global::GUI.Properties.Resources.cgpw_icon;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(178, 111);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(111, 40);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 163);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtComFirm);
            this.Controls.Add(this.txtPassWordMoi);
            this.Controls.Add(this.txtPasswordCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPasswordCu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWordMoi;
        private System.Windows.Forms.TextBox txtComFirm;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        public System.Windows.Forms.TextBox txtPasswordCu;
        public System.Windows.Forms.Label lblPasswordCu;
    }
}