namespace GUI.UC
{
    partial class UC_LopHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LopHC));
            this.lbnThongBao = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdLopHC = new System.Windows.Forms.BindingSource(this.components);
            this.gvDanhSachLopHC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaLopHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenLopHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNienKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCapNhatLopHC = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLopHC = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapHSExcell = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLopHC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnThongBao
            // 
            this.lbnThongBao.AutoSize = true;
            this.lbnThongBao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbnThongBao.Location = new System.Drawing.Point(363, 31);
            this.lbnThongBao.Name = "lbnThongBao";
            this.lbnThongBao.Size = new System.Drawing.Size(547, 23);
            this.lbnThongBao.TabIndex = 11;
            this.lbnThongBao.Text = "Danh Sách Các Lớp Hành chính của trường Mẫu giáo Bách Khoa";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bdLopHC;
            this.gridControl1.Location = new System.Drawing.Point(45, 74);
            this.gridControl1.MainView = this.gvDanhSachLopHC;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1118, 378);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachLopHC});
            // 
            // gvDanhSachLopHC
            // 
            this.gvDanhSachLopHC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaLopHC,
            this.clTenLopHC,
            this.clNienKhoa,
            this.clTenGiaoVien,
            this.clSoLuongHS});
            this.gvDanhSachLopHC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvDanhSachLopHC.GridControl = this.gridControl1;
            this.gvDanhSachLopHC.Name = "gvDanhSachLopHC";
            this.gvDanhSachLopHC.OptionsBehavior.Editable = false;
            this.gvDanhSachLopHC.OptionsFind.AlwaysVisible = true;
            this.gvDanhSachLopHC.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopHC.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopHC.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDanhSachLopHC.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachLopHC.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachLopHC.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvDanhSachLopHC_CustomDrawRowIndicator);
            this.gvDanhSachLopHC.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvDanhSachLopHC_CustomColumnDisplayText);
            this.gvDanhSachLopHC.RowCountChanged += new System.EventHandler(this.gvDanhSachLopHC_RowCountChanged);
            // 
            // clMaLopHC
            // 
            this.clMaLopHC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaLopHC.AppearanceCell.Options.UseFont = true;
            this.clMaLopHC.AppearanceCell.Options.UseTextOptions = true;
            this.clMaLopHC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaLopHC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaLopHC.AppearanceHeader.Options.UseFont = true;
            this.clMaLopHC.AppearanceHeader.Options.UseTextOptions = true;
            this.clMaLopHC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaLopHC.Caption = "Mã Lớp Hành Chính";
            this.clMaLopHC.FieldName = "MaLopHC";
            this.clMaLopHC.Name = "clMaLopHC";
            this.clMaLopHC.Visible = true;
            this.clMaLopHC.VisibleIndex = 0;
            // 
            // clTenLopHC
            // 
            this.clTenLopHC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenLopHC.AppearanceCell.Options.UseFont = true;
            this.clTenLopHC.AppearanceCell.Options.UseTextOptions = true;
            this.clTenLopHC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenLopHC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenLopHC.AppearanceHeader.Options.UseFont = true;
            this.clTenLopHC.AppearanceHeader.Options.UseTextOptions = true;
            this.clTenLopHC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenLopHC.Caption = "Tên Lớp Hành Chính";
            this.clTenLopHC.FieldName = "TenLopHC";
            this.clTenLopHC.Name = "clTenLopHC";
            this.clTenLopHC.Visible = true;
            this.clTenLopHC.VisibleIndex = 1;
            // 
            // clNienKhoa
            // 
            this.clNienKhoa.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNienKhoa.AppearanceCell.Options.UseFont = true;
            this.clNienKhoa.AppearanceCell.Options.UseTextOptions = true;
            this.clNienKhoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNienKhoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNienKhoa.AppearanceHeader.Options.UseFont = true;
            this.clNienKhoa.AppearanceHeader.Options.UseTextOptions = true;
            this.clNienKhoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNienKhoa.Caption = "Niên Khóa";
            this.clNienKhoa.FieldName = "NienKhoa";
            this.clNienKhoa.Name = "clNienKhoa";
            this.clNienKhoa.Visible = true;
            this.clNienKhoa.VisibleIndex = 2;
            // 
            // clTenGiaoVien
            // 
            this.clTenGiaoVien.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenGiaoVien.AppearanceCell.Options.UseFont = true;
            this.clTenGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.clTenGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.clTenGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.clTenGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenGiaoVien.Caption = "Tên Giáo Viên Chủ Nhiệm";
            this.clTenGiaoVien.FieldName = "TenGiaoVienChuNhiem";
            this.clTenGiaoVien.Name = "clTenGiaoVien";
            this.clTenGiaoVien.Visible = true;
            this.clTenGiaoVien.VisibleIndex = 3;
            // 
            // clSoLuongHS
            // 
            this.clSoLuongHS.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoLuongHS.AppearanceCell.Options.UseFont = true;
            this.clSoLuongHS.AppearanceCell.Options.UseTextOptions = true;
            this.clSoLuongHS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongHS.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoLuongHS.AppearanceHeader.Options.UseFont = true;
            this.clSoLuongHS.AppearanceHeader.Options.UseTextOptions = true;
            this.clSoLuongHS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongHS.Caption = "Số lượng học sinh trong lớp";
            this.clSoLuongHS.FieldName = "Soluong";
            this.clSoLuongHS.Name = "clSoLuongHS";
            this.clSoLuongHS.Visible = true;
            this.clSoLuongHS.VisibleIndex = 4;
            // 
            // btnCapNhatLopHC
            // 
            this.btnCapNhatLopHC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatLopHC.ImageOptions.Image")));
            this.btnCapNhatLopHC.Location = new System.Drawing.Point(760, 472);
            this.btnCapNhatLopHC.Name = "btnCapNhatLopHC";
            this.btnCapNhatLopHC.Size = new System.Drawing.Size(126, 45);
            this.btnCapNhatLopHC.TabIndex = 13;
            this.btnCapNhatLopHC.Text = "Cập nhật Lớp HC";
            this.btnCapNhatLopHC.Click += new System.EventHandler(this.btnCapNhatLopHC_Click);
            // 
            // btnThemLopHC
            // 
            this.btnThemLopHC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLopHC.ImageOptions.Image")));
            this.btnThemLopHC.Location = new System.Drawing.Point(580, 472);
            this.btnThemLopHC.Name = "btnThemLopHC";
            this.btnThemLopHC.Size = new System.Drawing.Size(119, 45);
            this.btnThemLopHC.TabIndex = 13;
            this.btnThemLopHC.Text = "Thêm Lớp HC";
            this.btnThemLopHC.Click += new System.EventHandler(this.btnThemLopHC_Click);
            // 
            // btnNhapHSExcell
            // 
            this.btnNhapHSExcell.ImageOptions.Image = global::GUI.Properties.Resources.excell_icon;
            this.btnNhapHSExcell.Location = new System.Drawing.Point(405, 472);
            this.btnNhapHSExcell.Name = "btnNhapHSExcell";
            this.btnNhapHSExcell.Size = new System.Drawing.Size(119, 45);
            this.btnNhapHSExcell.TabIndex = 13;
            this.btnNhapHSExcell.Text = "Excell Import";
            this.btnNhapHSExcell.Click += new System.EventHandler(this.btnNhapHSExcell_Click);
            // 
            // UC_LopHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNhapHSExcell);
            this.Controls.Add(this.btnThemLopHC);
            this.Controls.Add(this.btnCapNhatLopHC);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbnThongBao);
            this.Name = "UC_LopHC";
            this.Size = new System.Drawing.Size(1216, 545);
            this.Load += new System.EventHandler(this.UC_LopHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachLopHC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnThongBao;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachLopHC;
        private System.Windows.Forms.BindingSource bdLopHC;
        private DevExpress.XtraGrid.Columns.GridColumn clMaLopHC;
        private DevExpress.XtraGrid.Columns.GridColumn clTenLopHC;
        private DevExpress.XtraGrid.Columns.GridColumn clNienKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn clTenGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongHS;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLopHC;
        private DevExpress.XtraEditors.SimpleButton btnThemLopHC;
        private DevExpress.XtraEditors.SimpleButton btnNhapHSExcell;
    }
}
