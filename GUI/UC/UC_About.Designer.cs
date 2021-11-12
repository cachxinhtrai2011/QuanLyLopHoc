namespace GUI.UC
{
    partial class UC_About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGioiTHieu = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLinkGit = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblGioiTHieu
            // 
            this.lblGioiTHieu.AutoSize = true;
            this.lblGioiTHieu.BackColor = System.Drawing.Color.White;
            this.lblGioiTHieu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTHieu.Location = new System.Drawing.Point(246, 32);
            this.lblGioiTHieu.Name = "lblGioiTHieu";
            this.lblGioiTHieu.Size = new System.Drawing.Size(697, 31);
            this.lblGioiTHieu.TabIndex = 0;
            this.lblGioiTHieu.Text = "Phần Mềm Quản Lý Học Phí trường Mầm Non bách Khoa";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(538, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tác Giả: Trần Ngọc Nam - 13A2";
            // 
            // btnLinkGit
            // 
            this.btnLinkGit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.btnLinkGit.Appearance.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkGit.Appearance.Options.UseFont = true;
            this.btnLinkGit.Location = new System.Drawing.Point(475, 116);
            this.btnLinkGit.Name = "btnLinkGit";
            this.btnLinkGit.Size = new System.Drawing.Size(327, 19);
            this.btnLinkGit.TabIndex = 2;
            this.btnLinkGit.Text = "https://github.com/namnntt/TruongMamNonBK.git";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(535, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(207, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Điện Thoại Liên Hệ: 0339582455";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(316, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(153, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tham Khảo Mã Nguồn Tại: ";
            this.labelControl3.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // UC_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background2__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnLinkGit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblGioiTHieu);
            this.DoubleBuffered = true;
            this.Name = "UC_About";
            this.Size = new System.Drawing.Size(1216, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGioiTHieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl btnLinkGit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
