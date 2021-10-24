namespace GUI
{
    partial class frmChiTietDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDangKy));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHs = new System.Windows.Forms.TextBox();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtTenLopHC = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.adgvDanhSachLopDangDangKy = new Zuby.ADGV.AdvancedDataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaLopDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdLopdaDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.btnHUyDangKy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.adgvDanhSachLopDangDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopdaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(84, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Học Sinh";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Học Sinh";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp Hành chính";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtMaHs
            // 
            this.txtMaHs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaHs.Location = new System.Drawing.Point(148, 61);
            this.txtMaHs.Name = "txtMaHs";
            this.txtMaHs.ReadOnly = true;
            this.txtMaHs.Size = new System.Drawing.Size(228, 21);
            this.txtMaHs.TabIndex = 4;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenHS.Location = new System.Drawing.Point(148, 94);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.ReadOnly = true;
            this.txtTenHS.Size = new System.Drawing.Size(228, 21);
            this.txtTenHS.TabIndex = 5;
            // 
            // txtTenLopHC
            // 
            this.txtTenLopHC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLopHC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenLopHC.Location = new System.Drawing.Point(664, 61);
            this.txtTenLopHC.Name = "txtTenLopHC";
            this.txtTenLopHC.ReadOnly = true;
            this.txtTenLopHC.Size = new System.Drawing.Size(125, 21);
            this.txtTenLopHC.TabIndex = 6;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamSinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamSinh.Location = new System.Drawing.Point(664, 94);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.ReadOnly = true;
            this.txtNamSinh.Size = new System.Drawing.Size(125, 21);
            this.txtNamSinh.TabIndex = 7;
            // 
            // adgvDanhSachLopDangDangKy
            // 
            this.adgvDanhSachLopDangDangKy.AllowUserToAddRows = false;
            this.adgvDanhSachLopDangDangKy.AllowUserToDeleteRows = false;
            this.adgvDanhSachLopDangDangKy.AllowUserToResizeRows = false;
            this.adgvDanhSachLopDangDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvDanhSachLopDangDangKy.AutoGenerateColumns = false;
            this.adgvDanhSachLopDangDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvDanhSachLopDangDangKy.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvDanhSachLopDangDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvDanhSachLopDangDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clCheck,
            this.clMaLopDangKy,
            this.clTenLopDangKy,
            this.clTenCLB,
            this.clCLB,
            this.clNamHoc,
            this.clHocPhi,
            this.clLichHoc});
            this.adgvDanhSachLopDangDangKy.DataSource = this.bdLopdaDangKy;
            this.adgvDanhSachLopDangDangKy.FilterAndSortEnabled = true;
            this.adgvDanhSachLopDangDangKy.Location = new System.Drawing.Point(26, 150);
            this.adgvDanhSachLopDangDangKy.MultiSelect = false;
            this.adgvDanhSachLopDangDangKy.Name = "adgvDanhSachLopDangDangKy";
            this.adgvDanhSachLopDangDangKy.RowHeadersVisible = false;
            this.adgvDanhSachLopDangDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvDanhSachLopDangDangKy.Size = new System.Drawing.Size(819, 228);
            this.adgvDanhSachLopDangDangKy.TabIndex = 8;
            this.adgvDanhSachLopDangDangKy.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvDanhSachLopDangDangKy_RowPostPaint);
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 22;
            this.clSTT.Name = "clSTT";
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clSTT.Width = 50;
            // 
            // clCheck
            // 
            this.clCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCheck.HeaderText = "Chọn";
            this.clCheck.MinimumWidth = 22;
            this.clCheck.Name = "clCheck";
            this.clCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clCheck.Width = 57;
            // 
            // clMaLopDangKy
            // 
            this.clMaLopDangKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clMaLopDangKy.DataPropertyName = "MaLopDangKy";
            this.clMaLopDangKy.HeaderText = "Mã Lớp ĐK";
            this.clMaLopDangKy.MinimumWidth = 22;
            this.clMaLopDangKy.Name = "clMaLopDangKy";
            this.clMaLopDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clMaLopDangKy.Width = 83;
            // 
            // clTenLopDangKy
            // 
            this.clTenLopDangKy.DataPropertyName = "TenLopDangKy";
            this.clTenLopDangKy.HeaderText = "Tên Lớp";
            this.clTenLopDangKy.MinimumWidth = 22;
            this.clTenLopDangKy.Name = "clTenLopDangKy";
            this.clTenLopDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenCLB
            // 
            this.clTenCLB.DataPropertyName = "TenCLB";
            this.clTenCLB.HeaderText = "Tên CLB";
            this.clTenCLB.MinimumWidth = 22;
            this.clTenCLB.Name = "clTenCLB";
            this.clTenCLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clCLB
            // 
            this.clCLB.DataPropertyName = "CLB";
            this.clCLB.HeaderText = "CLB";
            this.clCLB.MinimumWidth = 22;
            this.clCLB.Name = "clCLB";
            this.clCLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clCLB.Visible = false;
            // 
            // clNamHoc
            // 
            this.clNamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clNamHoc.DataPropertyName = "NamHoc";
            this.clNamHoc.HeaderText = "Năm Học";
            this.clNamHoc.MinimumWidth = 22;
            this.clNamHoc.Name = "clNamHoc";
            this.clNamHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clNamHoc.Width = 74;
            // 
            // clHocPhi
            // 
            this.clHocPhi.DataPropertyName = "HocPhi";
            this.clHocPhi.HeaderText = "Học Phí";
            this.clHocPhi.MinimumWidth = 22;
            this.clHocPhi.Name = "clHocPhi";
            this.clHocPhi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clLichHoc
            // 
            this.clLichHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clLichHoc.DataPropertyName = "LichHoc";
            this.clLichHoc.HeaderText = "Lịch Học";
            this.clLichHoc.MinimumWidth = 22;
            this.clLichHoc.Name = "clLichHoc";
            this.clLichHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clLichHoc.Width = 71;
            // 
            // btnHUyDangKy
            // 
            this.btnHUyDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHUyDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHUyDangKy.ImageOptions.Image")));
            this.btnHUyDangKy.Location = new System.Drawing.Point(387, 404);
            this.btnHUyDangKy.Name = "btnHUyDangKy";
            this.btnHUyDangKy.Size = new System.Drawing.Size(112, 36);
            this.btnHUyDangKy.TabIndex = 9;
            this.btnHUyDangKy.Text = "Hủy Đăng Ký";
            this.btnHUyDangKy.Click += new System.EventHandler(this.btnHUyDangKy_Click);
            // 
            // frmChiTietDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 452);
            this.Controls.Add(this.btnHUyDangKy);
            this.Controls.Add(this.adgvDanhSachLopDangDangKy);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.txtTenLopHC);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.txtMaHs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTietDangKy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đăng ký";
            this.Load += new System.EventHandler(this.frmChiTietDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvDanhSachLopDangDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopdaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHs;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtTenLopHC;
        private System.Windows.Forms.TextBox txtNamSinh;
        private Zuby.ADGV.AdvancedDataGridView adgvDanhSachLopDangDangKy;
        private System.Windows.Forms.BindingSource bdLopdaDangKy;
        private DevExpress.XtraEditors.SimpleButton btnHUyDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLopDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLichHoc;
    }
}