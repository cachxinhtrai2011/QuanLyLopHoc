namespace GUI
{
    partial class frmDanhSachCLB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachCLB));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdCLB = new System.Windows.Forms.BindingSource(this.components);
            this.gvCLB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaCLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenCLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemCLB = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaCLB = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenCLB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCOmfirmThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnComfirmEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lbnThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCLB)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bdCLB;
            this.gridControl1.Location = new System.Drawing.Point(49, 47);
            this.gridControl1.MainView = this.gvCLB;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(515, 225);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCLB});
            // 
            // gvCLB
            // 
            this.gvCLB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaCLB,
            this.clTenCLB});
            this.gvCLB.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCLB.GridControl = this.gridControl1;
            this.gvCLB.Name = "gvCLB";
            this.gvCLB.OptionsBehavior.Editable = false;
            this.gvCLB.OptionsFind.AlwaysVisible = true;
            this.gvCLB.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvCLB.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCLB.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvCLB.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvCLB.OptionsView.ShowGroupPanel = false;
            this.gvCLB.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvCLB_CustomDrawRowIndicator);
            this.gvCLB.RowCountChanged += new System.EventHandler(this.gvCLB_RowCountChanged);
            // 
            // clMaCLB
            // 
            this.clMaCLB.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaCLB.AppearanceCell.Options.UseFont = true;
            this.clMaCLB.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaCLB.AppearanceHeader.Options.UseFont = true;
            this.clMaCLB.Caption = "Mã CLB";
            this.clMaCLB.FieldName = "MaCLB";
            this.clMaCLB.Name = "clMaCLB";
            this.clMaCLB.Visible = true;
            this.clMaCLB.VisibleIndex = 0;
            this.clMaCLB.Width = 92;
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
            this.clTenCLB.VisibleIndex = 1;
            this.clTenCLB.Width = 405;
            // 
            // btnThemCLB
            // 
            this.btnThemCLB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCLB.ImageOptions.Image")));
            this.btnThemCLB.Location = new System.Drawing.Point(171, 289);
            this.btnThemCLB.Name = "btnThemCLB";
            this.btnThemCLB.Size = new System.Drawing.Size(98, 40);
            this.btnThemCLB.TabIndex = 1;
            this.btnThemCLB.Text = "Thêm CLB";
            this.btnThemCLB.Click += new System.EventHandler(this.btnThemCLB_Click);
            // 
            // btnSuaCLB
            // 
            this.btnSuaCLB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCLB.ImageOptions.Image")));
            this.btnSuaCLB.Location = new System.Drawing.Point(334, 289);
            this.btnSuaCLB.Name = "btnSuaCLB";
            this.btnSuaCLB.Size = new System.Drawing.Size(108, 40);
            this.btnSuaCLB.TabIndex = 2;
            this.btnSuaCLB.Text = "Sửa TT CLB";
            this.btnSuaCLB.Click += new System.EventHandler(this.btnSuaCLB_Click);
            // 
            // txtTenCLB
            // 
            this.txtTenCLB.Enabled = false;
            this.txtTenCLB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCLB.Location = new System.Drawing.Point(135, 374);
            this.txtTenCLB.Name = "txtTenCLB";
            this.txtTenCLB.Size = new System.Drawing.Size(196, 25);
            this.txtTenCLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên CLB";
            // 
            // btnCOmfirmThem
            // 
            this.btnCOmfirmThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOmfirmThem.Appearance.Options.UseFont = true;
            this.btnCOmfirmThem.Enabled = false;
            this.btnCOmfirmThem.Location = new System.Drawing.Point(360, 366);
            this.btnCOmfirmThem.Name = "btnCOmfirmThem";
            this.btnCOmfirmThem.Size = new System.Drawing.Size(82, 36);
            this.btnCOmfirmThem.TabIndex = 5;
            this.btnCOmfirmThem.Text = "Xác Nhân thêm";
            this.btnCOmfirmThem.Click += new System.EventHandler(this.btnCOmfirmThem_Click);
            // 
            // btnComfirmEdit
            // 
            this.btnComfirmEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirmEdit.Appearance.Options.UseFont = true;
            this.btnComfirmEdit.Enabled = false;
            this.btnComfirmEdit.Location = new System.Drawing.Point(463, 366);
            this.btnComfirmEdit.Name = "btnComfirmEdit";
            this.btnComfirmEdit.Size = new System.Drawing.Size(80, 36);
            this.btnComfirmEdit.TabIndex = 6;
            this.btnComfirmEdit.Text = "Xác Nhận sửa";
            this.btnComfirmEdit.Click += new System.EventHandler(this.btnComfirmEdit_Click);
            // 
            // lbnThongBao
            // 
            this.lbnThongBao.AutoSize = true;
            this.lbnThongBao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbnThongBao.Location = new System.Drawing.Point(96, 9);
            this.lbnThongBao.Name = "lbnThongBao";
            this.lbnThongBao.Size = new System.Drawing.Size(392, 23);
            this.lbnThongBao.TabIndex = 12;
            this.lbnThongBao.Text = "Danh Sách các CLB của Trường Mẫu giáo BK";
            // 
            // frmDanhSachCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 438);
            this.Controls.Add(this.lbnThongBao);
            this.Controls.Add(this.btnComfirmEdit);
            this.Controls.Add(this.btnCOmfirmThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenCLB);
            this.Controls.Add(this.btnSuaCLB);
            this.Controls.Add(this.btnThemCLB);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachCLB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachCLB";
            this.Load += new System.EventHandler(this.frmDanhSachCLB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCLB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCLB;
        private DevExpress.XtraGrid.Columns.GridColumn clMaCLB;
        private DevExpress.XtraGrid.Columns.GridColumn clTenCLB;
        private System.Windows.Forms.BindingSource bdCLB;
        private DevExpress.XtraEditors.SimpleButton btnThemCLB;
        private DevExpress.XtraEditors.SimpleButton btnSuaCLB;
        private System.Windows.Forms.TextBox txtTenCLB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCOmfirmThem;
        private DevExpress.XtraEditors.SimpleButton btnComfirmEdit;
        private System.Windows.Forms.Label lbnThongBao;
    }
}