namespace GUI
{
    partial class frmCapNhatLopHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatLopHC));
            this.txtTenLopHC = new System.Windows.Forms.TextBox();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.txtTenGiaoVienCN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaTTLopHC = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnADdThemLopMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLopHC
            // 
            this.txtTenLopHC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLopHC.Location = new System.Drawing.Point(147, 48);
            this.txtTenLopHC.Name = "txtTenLopHC";
            this.txtTenLopHC.Size = new System.Drawing.Size(273, 25);
            this.txtTenLopHC.TabIndex = 0;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Location = new System.Drawing.Point(147, 86);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(273, 25);
            this.txtNienKhoa.TabIndex = 1;
            // 
            // txtTenGiaoVienCN
            // 
            this.txtTenGiaoVienCN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiaoVienCN.Location = new System.Drawing.Point(147, 124);
            this.txtTenGiaoVienCN.Name = "txtTenGiaoVienCN";
            this.txtTenGiaoVienCN.Size = new System.Drawing.Size(273, 25);
            this.txtTenGiaoVienCN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Lớp Hành chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niên Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên GV chủ nhiệm";
            // 
            // btnSuaTTLopHC
            // 
            this.btnSuaTTLopHC.ImageOptions.Image = global::GUI.Properties.Resources.edit_info_icon;
            this.btnSuaTTLopHC.Location = new System.Drawing.Point(109, 166);
            this.btnSuaTTLopHC.Name = "btnSuaTTLopHC";
            this.btnSuaTTLopHC.Size = new System.Drawing.Size(103, 43);
            this.btnSuaTTLopHC.TabIndex = 3;
            this.btnSuaTTLopHC.Text = "Sửa TT Lớp";
            this.btnSuaTTLopHC.Click += new System.EventHandler(this.btnSuaTTLopHC_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnADdThemLopMoi
            // 
            this.btnADdThemLopMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnADdThemLopMoi.ImageOptions.Image")));
            this.btnADdThemLopMoi.Location = new System.Drawing.Point(234, 166);
            this.btnADdThemLopMoi.Name = "btnADdThemLopMoi";
            this.btnADdThemLopMoi.Size = new System.Drawing.Size(103, 43);
            this.btnADdThemLopMoi.TabIndex = 4;
            this.btnADdThemLopMoi.Text = "Thêm Lớp";
            this.btnADdThemLopMoi.Click += new System.EventHandler(this.btnADdThemLopMoi_Click);
            // 
            // frmCapNhatLopHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 233);
            this.Controls.Add(this.btnADdThemLopMoi);
            this.Controls.Add(this.btnSuaTTLopHC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenGiaoVienCN);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.txtTenLopHC);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatLopHC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Lớp Hành chính";
            this.Load += new System.EventHandler(this.frmCapNhatLopHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLopHC;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.TextBox txtTenGiaoVienCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSuaTTLopHC;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.SimpleButton btnADdThemLopMoi;
    }
}