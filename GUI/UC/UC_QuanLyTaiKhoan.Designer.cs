namespace GUI.UC
{
    partial class UC_QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QuanLyTaiKhoan));
            this.lbnThongBao = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdDanhSachTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.gvGiaoVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaGiaVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaThongTinTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDanhSachTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnThongBao
            // 
            this.lbnThongBao.AutoSize = true;
            this.lbnThongBao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbnThongBao.Location = new System.Drawing.Point(519, 33);
            this.lbnThongBao.Name = "lbnThongBao";
            this.lbnThongBao.Size = new System.Drawing.Size(262, 23);
            this.lbnThongBao.TabIndex = 11;
            this.lbnThongBao.Text = "Danh Sách Tài khoản Giáo Vụ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdDanhSachTaiKhoan;
            this.gridControl1.Location = new System.Drawing.Point(50, 73);
            this.gridControl1.MainView = this.gvGiaoVu;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1157, 388);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGiaoVu});
            // 
            // gvGiaoVu
            // 
            this.gvGiaoVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaGiaVu,
            this.clTenGV,
            this.clTaiKhoan,
            this.clEmail,
            this.clPhone});
            this.gvGiaoVu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGiaoVu.GridControl = this.gridControl1;
            this.gvGiaoVu.Name = "gvGiaoVu";
            this.gvGiaoVu.OptionsBehavior.Editable = false;
            this.gvGiaoVu.OptionsFind.AlwaysVisible = true;
            this.gvGiaoVu.OptionsFind.FindDelay = 500;
            this.gvGiaoVu.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvGiaoVu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvGiaoVu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvGiaoVu.OptionsView.ShowGroupPanel = false;
            this.gvGiaoVu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvGiaoVu_CustomDrawRowIndicator);
            this.gvGiaoVu.RowCountChanged += new System.EventHandler(this.gvGiaoVu_RowCountChanged);
            // 
            // clMaGiaVu
            // 
            this.clMaGiaVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaGiaVu.AppearanceCell.Options.UseFont = true;
            this.clMaGiaVu.AppearanceCell.Options.UseTextOptions = true;
            this.clMaGiaVu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaGiaVu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaGiaVu.AppearanceHeader.Options.UseFont = true;
            this.clMaGiaVu.AppearanceHeader.Options.UseTextOptions = true;
            this.clMaGiaVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaGiaVu.Caption = "Mã Giáo Vụ";
            this.clMaGiaVu.FieldName = "MaGV";
            this.clMaGiaVu.Name = "clMaGiaVu";
            this.clMaGiaVu.Visible = true;
            this.clMaGiaVu.VisibleIndex = 0;
            this.clMaGiaVu.Width = 143;
            // 
            // clTenGV
            // 
            this.clTenGV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenGV.AppearanceCell.Options.UseFont = true;
            this.clTenGV.AppearanceCell.Options.UseTextOptions = true;
            this.clTenGV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenGV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenGV.AppearanceHeader.Options.UseFont = true;
            this.clTenGV.AppearanceHeader.Options.UseTextOptions = true;
            this.clTenGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenGV.Caption = "Tên Giáo Vụ";
            this.clTenGV.FieldName = "TenGiaoVu";
            this.clTenGV.Name = "clTenGV";
            this.clTenGV.Visible = true;
            this.clTenGV.VisibleIndex = 1;
            this.clTenGV.Width = 247;
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTaiKhoan.AppearanceCell.Options.UseFont = true;
            this.clTaiKhoan.AppearanceCell.Options.UseTextOptions = true;
            this.clTaiKhoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTaiKhoan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTaiKhoan.AppearanceHeader.Options.UseFont = true;
            this.clTaiKhoan.AppearanceHeader.Options.UseTextOptions = true;
            this.clTaiKhoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTaiKhoan.Caption = "Tài Khoản";
            this.clTaiKhoan.FieldName = "TaiKhoan";
            this.clTaiKhoan.Name = "clTaiKhoan";
            this.clTaiKhoan.Visible = true;
            this.clTaiKhoan.VisibleIndex = 2;
            this.clTaiKhoan.Width = 247;
            // 
            // clEmail
            // 
            this.clEmail.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clEmail.AppearanceCell.Options.UseFont = true;
            this.clEmail.AppearanceCell.Options.UseTextOptions = true;
            this.clEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clEmail.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clEmail.AppearanceHeader.Options.UseFont = true;
            this.clEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.clEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clEmail.Caption = "Email Của giáo vụ";
            this.clEmail.FieldName = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.Visible = true;
            this.clEmail.VisibleIndex = 3;
            this.clEmail.Width = 283;
            // 
            // clPhone
            // 
            this.clPhone.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clPhone.AppearanceCell.Options.UseFont = true;
            this.clPhone.AppearanceCell.Options.UseTextOptions = true;
            this.clPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clPhone.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clPhone.AppearanceHeader.Options.UseFont = true;
            this.clPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.clPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clPhone.Caption = "Điện thoại Giáo Vụ";
            this.clPhone.FieldName = "DienThoai";
            this.clPhone.Name = "clPhone";
            this.clPhone.Visible = true;
            this.clPhone.VisibleIndex = 4;
            this.clPhone.Width = 219;
            // 
            // btnSuaThongTinTK
            // 
            this.btnSuaThongTinTK.ImageOptions.Image = global::GUI.Properties.Resources.edit_tt_Giao_vu;
            this.btnSuaThongTinTK.Location = new System.Drawing.Point(387, 484);
            this.btnSuaThongTinTK.Name = "btnSuaThongTinTK";
            this.btnSuaThongTinTK.Size = new System.Drawing.Size(109, 44);
            this.btnSuaThongTinTK.TabIndex = 13;
            this.btnSuaThongTinTK.Text = "Sửa TTGV";
            this.btnSuaThongTinTK.Click += new System.EventHandler(this.btnSuaThongTinTK_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.ImageOptions.Image = global::GUI.Properties.Resources.reset_Password_gv_icon;
            this.btnResetPassword.Location = new System.Drawing.Point(558, 484);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(108, 44);
            this.btnResetPassword.TabIndex = 14;
            this.btnResetPassword.Text = "Đặt Lại PW";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTaiKhoan.ImageOptions.Image")));
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(728, 484);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(107, 44);
            this.btnThemTaiKhoan.TabIndex = 15;
            this.btnThemTaiKhoan.Text = "Thêm TK mới";
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // UC_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSuaThongTinTK);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbnThongBao);
            this.Name = "UC_QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1251, 545);
            this.Load += new System.EventHandler(this.UC_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDanhSachTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnThongBao;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bdDanhSachTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGiaoVu;
        private DevExpress.XtraGrid.Columns.GridColumn clMaGiaVu;
        private DevExpress.XtraGrid.Columns.GridColumn clTenGV;
        private DevExpress.XtraGrid.Columns.GridColumn clTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn clEmail;
        private DevExpress.XtraGrid.Columns.GridColumn clPhone;
        private DevExpress.XtraEditors.SimpleButton btnSuaThongTinTK;
        private DevExpress.XtraEditors.SimpleButton btnResetPassword;
        private DevExpress.XtraEditors.SimpleButton btnThemTaiKhoan;
    }
}
