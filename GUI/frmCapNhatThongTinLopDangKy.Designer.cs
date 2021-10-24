namespace GUI
{
    partial class frmCapNhatThongTinLopDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatThongTinLopDangKy));
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cbCLB = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.txtLichHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhatTTlop = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThemLopMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(111, 42);
            this.txtTenLop.MaxLength = 255;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(335, 25);
            this.txtTenLop.TabIndex = 0;
            // 
            // cbCLB
            // 
            this.cbCLB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCLB.FormattingEnabled = true;
            this.cbCLB.Location = new System.Drawing.Point(111, 87);
            this.cbCLB.Name = "cbCLB";
            this.cbCLB.Size = new System.Drawing.Size(182, 25);
            this.cbCLB.TabIndex = 1;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(111, 132);
            this.txtNamHoc.MaxLength = 4;
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(335, 25);
            this.txtNamHoc.TabIndex = 0;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Location = new System.Drawing.Point(111, 177);
            this.txtHocPhi.MaxLength = 25;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(335, 25);
            this.txtHocPhi.TabIndex = 0;
            // 
            // txtLichHoc
            // 
            this.txtLichHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLichHoc.Location = new System.Drawing.Point(111, 222);
            this.txtLichHoc.MaxLength = 1;
            this.txtLichHoc.Name = "txtLichHoc";
            this.txtLichHoc.Size = new System.Drawing.Size(335, 25);
            this.txtLichHoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học Phí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lịch Học (Thứ)";
            // 
            // btnCapNhatTTlop
            // 
            this.btnCapNhatTTlop.ImageOptions.Image = global::GUI.Properties.Resources.updarte_infomatrion;
            this.btnCapNhatTTlop.Location = new System.Drawing.Point(98, 266);
            this.btnCapNhatTTlop.Name = "btnCapNhatTTlop";
            this.btnCapNhatTTlop.Size = new System.Drawing.Size(127, 44);
            this.btnCapNhatTTlop.TabIndex = 3;
            this.btnCapNhatTTlop.Text = "Cập nhật TT Lớp";
            this.btnCapNhatTTlop.Click += new System.EventHandler(this.btnCapNhatTTlop_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnThemLopMoi
            // 
            this.btnThemLopMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLopMoi.ImageOptions.Image")));
            this.btnThemLopMoi.Location = new System.Drawing.Point(253, 266);
            this.btnThemLopMoi.Name = "btnThemLopMoi";
            this.btnThemLopMoi.Size = new System.Drawing.Size(127, 44);
            this.btnThemLopMoi.TabIndex = 3;
            this.btnThemLopMoi.Text = "Thêm Lớp Mới";
            this.btnThemLopMoi.Click += new System.EventHandler(this.btnThemLopMoi_Click);
            // 
            // frmCapNhatThongTinLopDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.btnThemLopMoi);
            this.Controls.Add(this.btnCapNhatTTlop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCLB);
            this.Controls.Add(this.txtLichHoc);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtTenLop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatThongTinLopDangKy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lớp Đăng Ký";
            this.Load += new System.EventHandler(this.frmCapNhatThongTinLopDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cbCLB;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.TextBox txtLichHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public DevExpress.XtraEditors.SimpleButton btnThemLopMoi;
        public DevExpress.XtraEditors.SimpleButton btnCapNhatTTlop;
    }
}