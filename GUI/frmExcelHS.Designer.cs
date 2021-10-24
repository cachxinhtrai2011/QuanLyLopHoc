namespace GUI
{
    partial class frmExcelHS
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdExcell = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clTenHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenChaMe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSDTChaMe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clLopHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opfDexcel = new System.Windows.Forms.OpenFileDialog();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnfindFile = new DevExpress.XtraEditors.SimpleButton();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.btnSaveDataBase = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdExcell;
            this.gridControl1.Location = new System.Drawing.Point(21, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 324);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clTenHS,
            this.clNgaySinh,
            this.clTenChaMe,
            this.clSDTChaMe,
            this.clAddress,
            this.clLopHC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // clTenHS
            // 
            this.clTenHS.Caption = "Tên HS";
            this.clTenHS.Name = "clTenHS";
            this.clTenHS.Visible = true;
            this.clTenHS.VisibleIndex = 1;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Caption = "Ngày Sinh";
            this.clNgaySinh.DisplayFormat.FormatString = "d";
            this.clNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Visible = true;
            this.clNgaySinh.VisibleIndex = 2;
            // 
            // clTenChaMe
            // 
            this.clTenChaMe.Caption = "Tên Cha Mẹ";
            this.clTenChaMe.Name = "clTenChaMe";
            this.clTenChaMe.Visible = true;
            this.clTenChaMe.VisibleIndex = 3;
            // 
            // clSDTChaMe
            // 
            this.clSDTChaMe.Caption = "SĐT Cha Mẹ";
            this.clSDTChaMe.Name = "clSDTChaMe";
            this.clSDTChaMe.Visible = true;
            this.clSDTChaMe.VisibleIndex = 4;
            // 
            // clAddress
            // 
            this.clAddress.Caption = "Địa chỉ";
            this.clAddress.Name = "clAddress";
            this.clAddress.Visible = true;
            this.clAddress.VisibleIndex = 5;
            // 
            // clLopHC
            // 
            this.clLopHC.Caption = "Lớp Hành chính";
            this.clLopHC.Name = "clLopHC";
            this.clLopHC.Visible = true;
            this.clLopHC.VisibleIndex = 6;
            // 
            // opfDexcel
            // 
            this.opfDexcel.Filter = "Excel 2010-2016|*.xlsx|Excel 1997-2003|*.xls";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(87, 352);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(616, 21);
            this.txtLink.TabIndex = 1;
            // 
            // btnfindFile
            // 
            this.btnfindFile.Location = new System.Drawing.Point(709, 352);
            this.btnfindFile.Name = "btnfindFile";
            this.btnfindFile.Size = new System.Drawing.Size(86, 23);
            this.btnfindFile.TabIndex = 2;
            this.btnfindFile.Text = "Tìm File";
            this.btnfindFile.Click += new System.EventHandler(this.btnfindFile_Click);
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(87, 379);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(138, 21);
            this.cbSheet.TabIndex = 3;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // btnSaveDataBase
            // 
            this.btnSaveDataBase.ImageOptions.Image = global::GUI.Properties.Resources.save_database_icon;
            this.btnSaveDataBase.Location = new System.Drawing.Point(362, 415);
            this.btnSaveDataBase.Name = "btnSaveDataBase";
            this.btnSaveDataBase.Size = new System.Drawing.Size(109, 37);
            this.btnSaveDataBase.TabIndex = 4;
            this.btnSaveDataBase.Text = "Lưu vào CSDL";
            this.btnSaveDataBase.Click += new System.EventHandler(this.btnSaveDataBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Link đến file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Sheet";
            // 
            // frmExcelHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveDataBase);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.btnfindFile);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExcelHS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập từ Excel vào CSDL";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.OpenFileDialog opfDexcel;
        private System.Windows.Forms.TextBox txtLink;
        private DevExpress.XtraEditors.SimpleButton btnfindFile;
        private System.Windows.Forms.ComboBox cbSheet;
        private DevExpress.XtraEditors.SimpleButton btnSaveDataBase;
        private System.Windows.Forms.BindingSource bdExcell;
        private DevExpress.XtraGrid.Columns.GridColumn clTenHS;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clTenChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clSDTChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clLopHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}