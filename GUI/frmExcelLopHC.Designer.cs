namespace GUI
{
    partial class frmExcelLopHC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.btnTimFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.opfDexcel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bdExcell;
            this.gridControl1.Location = new System.Drawing.Point(21, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 300);
            this.gridControl1.TabIndex = 1;
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
            this.clAddress});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chọn Sheet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Link đến file";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::GUI.Properties.Resources.save_database_icon;
            this.btnSave.Location = new System.Drawing.Point(352, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu vào CSDL";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(79, 372);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(138, 21);
            this.cbSheet.TabIndex = 9;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // btnTimFile
            // 
            this.btnTimFile.Location = new System.Drawing.Point(687, 338);
            this.btnTimFile.Name = "btnTimFile";
            this.btnTimFile.Size = new System.Drawing.Size(86, 23);
            this.btnTimFile.TabIndex = 8;
            this.btnTimFile.Text = "Tìm File";
            this.btnTimFile.Click += new System.EventHandler(this.btnTimFile_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(79, 340);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(602, 21);
            this.txtLink.TabIndex = 7;
            // 
            // frmExcelLopHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.btnTimFile);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExcelLopHC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lưu Học sinh vào Excel";
            this.Load += new System.EventHandler(this.frmExcelLopHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clTenHS;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clTenChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clSDTChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ComboBox cbSheet;
        private DevExpress.XtraEditors.SimpleButton btnTimFile;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.OpenFileDialog opfDexcel;
        private System.Windows.Forms.BindingSource bdExcell;
    }
}