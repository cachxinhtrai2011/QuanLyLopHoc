namespace GUI.UC
{
    partial class UC_HuyDKHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HuyDKHoc));
            this.adgvLopDangKyH = new Zuby.ADGV.AdvancedDataGridView();
            this.clLSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLopDk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bddsLopTheoHS = new System.Windows.Forms.BindingSource(this.components);
            this.adgvHocSinhHuyDK = new Zuby.ADGV.AdvancedDataGridView();
            this.clHSSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChonHS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenChaMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.btnPickStd = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyDangKy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.adgvLopDangKyH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopTheoHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvHocSinhHuyDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvLopDangKyH
            // 
            this.adgvLopDangKyH.AllowUserToAddRows = false;
            this.adgvLopDangKyH.AllowUserToDeleteRows = false;
            this.adgvLopDangKyH.AllowUserToResizeRows = false;
            this.adgvLopDangKyH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvLopDangKyH.AutoGenerateColumns = false;
            this.adgvLopDangKyH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvLopDangKyH.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvLopDangKyH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvLopDangKyH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clLSTT,
            this.clMaLopDk,
            this.clTenLop,
            this.clTenCLB,
            this.clLichHoc,
            this.clNamHoc,
            this.clSoLuongHocSinh});
            this.adgvLopDangKyH.DataSource = this.bddsLopTheoHS;
            this.adgvLopDangKyH.FilterAndSortEnabled = false;
            this.adgvLopDangKyH.Location = new System.Drawing.Point(30, 52);
            this.adgvLopDangKyH.MultiSelect = false;
            this.adgvLopDangKyH.Name = "adgvLopDangKyH";
            this.adgvLopDangKyH.RowHeadersVisible = false;
            this.adgvLopDangKyH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvLopDangKyH.Size = new System.Drawing.Size(953, 192);
            this.adgvLopDangKyH.TabIndex = 0;
            this.adgvLopDangKyH.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvLopDangKyH_RowPostPaint);
            // 
            // clLSTT
            // 
            this.clLSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clLSTT.HeaderText = "STT";
            this.clLSTT.MinimumWidth = 22;
            this.clLSTT.Name = "clLSTT";
            this.clLSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clLSTT.Width = 50;
            // 
            // clMaLopDk
            // 
            this.clMaLopDk.DataPropertyName = "ID";
            this.clMaLopDk.HeaderText = "Mã lớp Đăng ký";
            this.clMaLopDk.MinimumWidth = 22;
            this.clMaLopDk.Name = "clMaLopDk";
            this.clMaLopDk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenLop
            // 
            this.clTenLop.DataPropertyName = "TenLopDangKy";
            this.clTenLop.HeaderText = "Tên Lớp";
            this.clTenLop.MinimumWidth = 22;
            this.clTenLop.Name = "clTenLop";
            this.clTenLop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenCLB
            // 
            this.clTenCLB.DataPropertyName = "TenCLB";
            this.clTenCLB.HeaderText = "Tên CLB";
            this.clTenCLB.MinimumWidth = 22;
            this.clTenCLB.Name = "clTenCLB";
            this.clTenCLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clLichHoc
            // 
            this.clLichHoc.DataPropertyName = "LichHoc";
            this.clLichHoc.HeaderText = "Lịch Học";
            this.clLichHoc.MinimumWidth = 22;
            this.clLichHoc.Name = "clLichHoc";
            this.clLichHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clNamHoc
            // 
            this.clNamHoc.DataPropertyName = "NamHoc";
            this.clNamHoc.HeaderText = "Năm Học";
            this.clNamHoc.MinimumWidth = 22;
            this.clNamHoc.Name = "clNamHoc";
            this.clNamHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clSoLuongHocSinh
            // 
            this.clSoLuongHocSinh.DataPropertyName = "Count";
            this.clSoLuongHocSinh.HeaderText = "Số Lượng";
            this.clSoLuongHocSinh.MinimumWidth = 22;
            this.clSoLuongHocSinh.Name = "clSoLuongHocSinh";
            this.clSoLuongHocSinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // adgvHocSinhHuyDK
            // 
            this.adgvHocSinhHuyDK.AllowUserToAddRows = false;
            this.adgvHocSinhHuyDK.AllowUserToDeleteRows = false;
            this.adgvHocSinhHuyDK.AllowUserToResizeRows = false;
            this.adgvHocSinhHuyDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvHocSinhHuyDK.AutoGenerateColumns = false;
            this.adgvHocSinhHuyDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvHocSinhHuyDK.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvHocSinhHuyDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvHocSinhHuyDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHSSTT,
            this.clChonHS,
            this.clMaHS,
            this.clTenHS,
            this.clTenLopHC,
            this.clDiaChi,
            this.clTenChaMe,
            this.clSDT});
            this.adgvHocSinhHuyDK.DataSource = this.bdHocSinh;
            this.adgvHocSinhHuyDK.FilterAndSortEnabled = true;
            this.adgvHocSinhHuyDK.Location = new System.Drawing.Point(30, 309);
            this.adgvHocSinhHuyDK.MultiSelect = false;
            this.adgvHocSinhHuyDK.Name = "adgvHocSinhHuyDK";
            this.adgvHocSinhHuyDK.RowHeadersVisible = false;
            this.adgvHocSinhHuyDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvHocSinhHuyDK.Size = new System.Drawing.Size(953, 188);
            this.adgvHocSinhHuyDK.TabIndex = 1;
            this.adgvHocSinhHuyDK.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.adgvHocSinhHuyDK_SortStringChanged);
            this.adgvHocSinhHuyDK.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.adgvHocSinhHuyDK_FilterStringChanged);
            this.adgvHocSinhHuyDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvHocSinhHuyDK_CellContentClick);
            this.adgvHocSinhHuyDK.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvHocSinhHuyDK_RowPostPaint);
            // 
            // clHSSTT
            // 
            this.clHSSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clHSSTT.HeaderText = "STT";
            this.clHSSTT.MinimumWidth = 22;
            this.clHSSTT.Name = "clHSSTT";
            this.clHSSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clHSSTT.Width = 50;
            // 
            // clChonHS
            // 
            this.clChonHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clChonHS.HeaderText = "Chọn";
            this.clChonHS.MinimumWidth = 22;
            this.clChonHS.Name = "clChonHS";
            this.clChonHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clChonHS.Width = 57;
            // 
            // clMaHS
            // 
            this.clMaHS.DataPropertyName = "MaHS";
            this.clMaHS.HeaderText = "Mã HS";
            this.clMaHS.MinimumWidth = 22;
            this.clMaHS.Name = "clMaHS";
            this.clMaHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenHS
            // 
            this.clTenHS.DataPropertyName = "TenHS";
            this.clTenHS.HeaderText = "Tên HS";
            this.clTenHS.MinimumWidth = 22;
            this.clTenHS.Name = "clTenHS";
            this.clTenHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenLopHC
            // 
            this.clTenLopHC.DataPropertyName = "TenLopHC";
            this.clTenLopHC.HeaderText = "Tên Lớp HC";
            this.clTenLopHC.MinimumWidth = 22;
            this.clTenLopHC.Name = "clTenLopHC";
            this.clTenLopHC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle1.NullValue = "(Trống)";
            this.clDiaChi.DefaultCellStyle = dataGridViewCellStyle1;
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.MinimumWidth = 22;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenChaMe
            // 
            this.clTenChaMe.DataPropertyName = "TenChaMe";
            this.clTenChaMe.HeaderText = "Tên Cha Mẹ";
            this.clTenChaMe.MinimumWidth = 22;
            this.clTenChaMe.Name = "clTenChaMe";
            this.clTenChaMe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SDTChaMe";
            this.clSDT.HeaderText = "SĐT Cha Mẹ";
            this.clSDT.MinimumWidth = 22;
            this.clSDT.Name = "clSDT";
            this.clSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnPickStd
            // 
            this.btnPickStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPickStd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPickStd.ImageOptions.Image")));
            this.btnPickStd.Location = new System.Drawing.Point(459, 250);
            this.btnPickStd.Name = "btnPickStd";
            this.btnPickStd.Size = new System.Drawing.Size(121, 41);
            this.btnPickStd.TabIndex = 2;
            this.btnPickStd.Text = "Chọn Lớp";
            this.btnPickStd.Click += new System.EventHandler(this.btnChonLop_Click);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHuyDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDangKy.ImageOptions.Image")));
            this.btnHuyDangKy.Location = new System.Drawing.Point(468, 503);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(121, 39);
            this.btnHuyDangKy.TabIndex = 3;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // UC_HuyDKHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuyDangKy);
            this.Controls.Add(this.btnPickStd);
            this.Controls.Add(this.adgvHocSinhHuyDK);
            this.Controls.Add(this.adgvLopDangKyH);
            this.Name = "UC_HuyDKHoc";
            this.Size = new System.Drawing.Size(1014, 556);
            this.Load += new System.EventHandler(this.UC_HuyDKHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvLopDangKyH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopTheoHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvHocSinhHuyDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgvLopDangKyH;
        private System.Windows.Forms.BindingSource bddsLopTheoHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLopDk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongHocSinh;
        private Zuby.ADGV.AdvancedDataGridView adgvHocSinhHuyDK;
        private System.Windows.Forms.BindingSource bdHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHSSTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clChonHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenChaMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private DevExpress.XtraEditors.SimpleButton btnHuyDangKy;
        public DevExpress.XtraEditors.SimpleButton btnPickStd;
    }
}
