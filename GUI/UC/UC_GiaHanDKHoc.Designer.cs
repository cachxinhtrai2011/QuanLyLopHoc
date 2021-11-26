namespace GUI.UC
{
    partial class UC_GiaHanDKHoc
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
            this.adgvdsHSGiaHanDK = new Zuby.ADGV.AdvancedDataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenChame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDTChaMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdDsHSGiaHan = new System.Windows.Forms.BindingSource(this.components);
            this.btnGiaHan = new DevExpress.XtraEditors.SimpleButton();
            this.advancedDataGridViewSearchToolBar1 = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.adgvdsHSGiaHanDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDsHSGiaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvdsHSGiaHanDK
            // 
            this.adgvdsHSGiaHanDK.AllowUserToAddRows = false;
            this.adgvdsHSGiaHanDK.AllowUserToDeleteRows = false;
            this.adgvdsHSGiaHanDK.AllowUserToResizeRows = false;
            this.adgvdsHSGiaHanDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvdsHSGiaHanDK.AutoGenerateColumns = false;
            this.adgvdsHSGiaHanDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvdsHSGiaHanDK.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvdsHSGiaHanDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvdsHSGiaHanDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clCheckBox,
            this.clMaHS,
            this.clTenHS,
            this.clTenLopHC,
            this.clDiaChi,
            this.clTenChame,
            this.clSDTChaMe});
            this.adgvdsHSGiaHanDK.DataSource = this.bdDsHSGiaHan;
            this.adgvdsHSGiaHanDK.FilterAndSortEnabled = true;
            this.adgvdsHSGiaHanDK.Location = new System.Drawing.Point(46, 81);
            this.adgvdsHSGiaHanDK.MultiSelect = false;
            this.adgvdsHSGiaHanDK.Name = "adgvdsHSGiaHanDK";
            this.adgvdsHSGiaHanDK.RowHeadersVisible = false;
            this.adgvdsHSGiaHanDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvdsHSGiaHanDK.Size = new System.Drawing.Size(1146, 372);
            this.adgvdsHSGiaHanDK.TabIndex = 0;
            this.adgvdsHSGiaHanDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvdsHSGiaHanDK_CellContentClick);
            this.adgvdsHSGiaHanDK.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvdsHSGiaHanDK_RowPostPaint);
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
            // clCheckBox
            // 
            this.clCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCheckBox.HeaderText = "Chọn";
            this.clCheckBox.MinimumWidth = 22;
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clCheckBox.Width = 57;
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
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.MinimumWidth = 22;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenChame
            // 
            this.clTenChame.DataPropertyName = "TenChaMe";
            this.clTenChame.HeaderText = "Tên Cha Mẹ";
            this.clTenChame.MinimumWidth = 22;
            this.clTenChame.Name = "clTenChame";
            this.clTenChame.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clSDTChaMe
            // 
            this.clSDTChaMe.DataPropertyName = "SDTChaMe";
            this.clSDTChaMe.HeaderText = "SĐT Cha Mẹ";
            this.clSDTChaMe.MinimumWidth = 22;
            this.clSDTChaMe.Name = "clSDTChaMe";
            this.clSDTChaMe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGiaHan.ImageOptions.Image = global::GUI.Properties.Resources.renew_icon;
            this.btnGiaHan.Location = new System.Drawing.Point(577, 469);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(117, 38);
            this.btnGiaHan.TabIndex = 1;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // advancedDataGridViewSearchToolBar1
            // 
            this.advancedDataGridViewSearchToolBar1.AllowMerge = false;
            this.advancedDataGridViewSearchToolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.advancedDataGridViewSearchToolBar1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridViewSearchToolBar1.MaximumSize = new System.Drawing.Size(0, 27);
            this.advancedDataGridViewSearchToolBar1.MinimumSize = new System.Drawing.Size(0, 27);
            this.advancedDataGridViewSearchToolBar1.Name = "advancedDataGridViewSearchToolBar1";
            this.advancedDataGridViewSearchToolBar1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.advancedDataGridViewSearchToolBar1.Size = new System.Drawing.Size(1216, 27);
            this.advancedDataGridViewSearchToolBar1.TabIndex = 2;
            this.advancedDataGridViewSearchToolBar1.Text = "advancedDataGridViewSearchToolBar1";
            this.advancedDataGridViewSearchToolBar1.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.advancedDataGridViewSearchToolBar1_Search);
            // 
            // UC_GiaHanDKHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.advancedDataGridViewSearchToolBar1);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.adgvdsHSGiaHanDK);
            this.Name = "UC_GiaHanDKHoc";
            this.Size = new System.Drawing.Size(1216, 545);
            this.Load += new System.EventHandler(this.UC_GiaHanDKHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvdsHSGiaHanDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDsHSGiaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgvdsHSGiaHanDK;
        private DevExpress.XtraEditors.SimpleButton btnGiaHan;
        private System.Windows.Forms.BindingSource bdDsHSGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenChame;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDTChaMe;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar advancedDataGridViewSearchToolBar1;
    }
}
