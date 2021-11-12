namespace GUI.UC
{
    partial class UC_QuanLyLopvaCLB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QuanLyLopvaCLB));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bddsLopDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.gvDanhSachLopDangKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaLopDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenLopDangky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clHocPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clLichHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenCLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbnThongBao = new System.Windows.Forms.Label();
            this.btnThemLopMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhSachCLB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLopDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bddsLopDangKy;
            this.gridControl1.Location = new System.Drawing.Point(27, 69);
            this.gridControl1.MainView = this.gvDanhSachLopDangKy;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1156, 386);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachLopDangKy});
            // 
            // gvDanhSachLopDangKy
            // 
            this.gvDanhSachLopDangKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaLopDangKy,
            this.clTenLopDangky,
            this.clNamHoc,
            this.clHocPhi,
            this.clLichHoc,
            this.clTenCLB,
            this.clCLB});
            this.gvDanhSachLopDangKy.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvDanhSachLopDangKy.GridControl = this.gridControl1;
            this.gvDanhSachLopDangKy.Name = "gvDanhSachLopDangKy";
            this.gvDanhSachLopDangKy.OptionsBehavior.Editable = false;
            this.gvDanhSachLopDangKy.OptionsFind.AlwaysVisible = true;
            this.gvDanhSachLopDangKy.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopDangKy.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopDangKy.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDanhSachLopDangKy.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopDangKy.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachLopDangKy.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvDanhSachLopDangKy_CustomDrawRowIndicator);
            this.gvDanhSachLopDangKy.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvDanhSachLopDangKy_CustomColumnDisplayText);
            this.gvDanhSachLopDangKy.RowCountChanged += new System.EventHandler(this.gvDanhSachLopDangKy_RowCountChanged);
            // 
            // clMaLopDangKy
            // 
            this.clMaLopDangKy.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaLopDangKy.AppearanceCell.Options.UseFont = true;
            this.clMaLopDangKy.AppearanceCell.Options.UseTextOptions = true;
            this.clMaLopDangKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaLopDangKy.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaLopDangKy.AppearanceHeader.Options.UseFont = true;
            this.clMaLopDangKy.AppearanceHeader.Options.UseTextOptions = true;
            this.clMaLopDangKy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaLopDangKy.Caption = "Mã lớp Đăng Ký";
            this.clMaLopDangKy.FieldName = "MaLopDangKy";
            this.clMaLopDangKy.Name = "clMaLopDangKy";
            this.clMaLopDangKy.Visible = true;
            this.clMaLopDangKy.VisibleIndex = 0;
            // 
            // clTenLopDangky
            // 
            this.clTenLopDangky.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenLopDangky.AppearanceCell.Options.UseFont = true;
            this.clTenLopDangky.AppearanceCell.Options.UseTextOptions = true;
            this.clTenLopDangky.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenLopDangky.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenLopDangky.AppearanceHeader.Options.UseFont = true;
            this.clTenLopDangky.AppearanceHeader.Options.UseTextOptions = true;
            this.clTenLopDangky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenLopDangky.Caption = "Tên Lớp đăng ký";
            this.clTenLopDangky.FieldName = "TenLopDangKy";
            this.clTenLopDangky.Name = "clTenLopDangky";
            this.clTenLopDangky.Visible = true;
            this.clTenLopDangky.VisibleIndex = 1;
            // 
            // clNamHoc
            // 
            this.clNamHoc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNamHoc.AppearanceCell.Options.UseFont = true;
            this.clNamHoc.AppearanceCell.Options.UseTextOptions = true;
            this.clNamHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNamHoc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNamHoc.AppearanceHeader.Options.UseFont = true;
            this.clNamHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.clNamHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNamHoc.Caption = "Năm Học";
            this.clNamHoc.FieldName = "NamHoc";
            this.clNamHoc.Name = "clNamHoc";
            this.clNamHoc.Visible = true;
            this.clNamHoc.VisibleIndex = 2;
            // 
            // clHocPhi
            // 
            this.clHocPhi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clHocPhi.AppearanceCell.Options.UseFont = true;
            this.clHocPhi.AppearanceCell.Options.UseTextOptions = true;
            this.clHocPhi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clHocPhi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clHocPhi.AppearanceHeader.Options.UseFont = true;
            this.clHocPhi.AppearanceHeader.Options.UseTextOptions = true;
            this.clHocPhi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clHocPhi.Caption = "Học phí";
            this.clHocPhi.FieldName = "HocPhi";
            this.clHocPhi.Name = "clHocPhi";
            this.clHocPhi.Visible = true;
            this.clHocPhi.VisibleIndex = 3;
            // 
            // clLichHoc
            // 
            this.clLichHoc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLichHoc.AppearanceCell.Options.UseFont = true;
            this.clLichHoc.AppearanceCell.Options.UseTextOptions = true;
            this.clLichHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clLichHoc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLichHoc.AppearanceHeader.Options.UseFont = true;
            this.clLichHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.clLichHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clLichHoc.Caption = "Lịch Học";
            this.clLichHoc.FieldName = "LichHoc";
            this.clLichHoc.Name = "clLichHoc";
            this.clLichHoc.Visible = true;
            this.clLichHoc.VisibleIndex = 4;
            // 
            // clTenCLB
            // 
            this.clTenCLB.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenCLB.AppearanceCell.Options.UseFont = true;
            this.clTenCLB.AppearanceCell.Options.UseTextOptions = true;
            this.clTenCLB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenCLB.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenCLB.AppearanceHeader.Options.UseFont = true;
            this.clTenCLB.AppearanceHeader.Options.UseTextOptions = true;
            this.clTenCLB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenCLB.Caption = "Tên CLB";
            this.clTenCLB.FieldName = "TenCLB";
            this.clTenCLB.Name = "clTenCLB";
            this.clTenCLB.Visible = true;
            this.clTenCLB.VisibleIndex = 5;
            // 
            // clCLB
            // 
            this.clCLB.Caption = "Câu Lạc Bộ";
            this.clCLB.FieldName = "CLB";
            this.clCLB.Name = "clCLB";
            // 
            // lbnThongBao
            // 
            this.lbnThongBao.AutoSize = true;
            this.lbnThongBao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbnThongBao.Location = new System.Drawing.Point(426, 22);
            this.lbnThongBao.Name = "lbnThongBao";
            this.lbnThongBao.Size = new System.Drawing.Size(489, 23);
            this.lbnThongBao.TabIndex = 11;
            this.lbnThongBao.Text = "Danh sách Các Lớp Đăng Ký trường Mầm non Bách Khoa";
            // 
            // btnThemLopMoi
            // 
            this.btnThemLopMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLopMoi.ImageOptions.Image")));
            this.btnThemLopMoi.Location = new System.Drawing.Point(750, 472);
            this.btnThemLopMoi.Name = "btnThemLopMoi";
            this.btnThemLopMoi.Size = new System.Drawing.Size(107, 40);
            this.btnThemLopMoi.TabIndex = 12;
            this.btnThemLopMoi.Text = "Thêm lớp mới";
            this.btnThemLopMoi.Click += new System.EventHandler(this.btnThemLopMoi_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateInfo.ImageOptions.Image")));
            this.btnUpdateInfo.Location = new System.Drawing.Point(573, 472);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(107, 40);
            this.btnUpdateInfo.TabIndex = 12;
            this.btnUpdateInfo.Text = "Sửa TT Lớp";
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnDanhSachCLB
            // 
            this.btnDanhSachCLB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachCLB.ImageOptions.Image")));
            this.btnDanhSachCLB.Location = new System.Drawing.Point(386, 472);
            this.btnDanhSachCLB.Name = "btnDanhSachCLB";
            this.btnDanhSachCLB.Size = new System.Drawing.Size(117, 40);
            this.btnDanhSachCLB.TabIndex = 12;
            this.btnDanhSachCLB.Text = "Danh Sách CLB";
            this.btnDanhSachCLB.Click += new System.EventHandler(this.btnDanhSachCLB_Click);
            // 
            // UC_QuanLyLopvaCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDanhSachCLB);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnThemLopMoi);
            this.Controls.Add(this.lbnThongBao);
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_QuanLyLopvaCLB";
            this.Size = new System.Drawing.Size(1216, 545);
            this.Load += new System.EventHandler(this.UC_QuanLyLopvaCLB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLopDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachLopDangKy;
        private System.Windows.Forms.Label lbnThongBao;
        private DevExpress.XtraGrid.Columns.GridColumn clMaLopDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn clTenLopDangky;
        private DevExpress.XtraGrid.Columns.GridColumn clNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn clHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn clLichHoc;
        private DevExpress.XtraGrid.Columns.GridColumn clTenCLB;
        private DevExpress.XtraGrid.Columns.GridColumn clCLB;
        private System.Windows.Forms.BindingSource bddsLopDangKy;
        private DevExpress.XtraEditors.SimpleButton btnThemLopMoi;
        private DevExpress.XtraEditors.SimpleButton btnUpdateInfo;
        private DevExpress.XtraEditors.SimpleButton btnDanhSachCLB;
    }
}
