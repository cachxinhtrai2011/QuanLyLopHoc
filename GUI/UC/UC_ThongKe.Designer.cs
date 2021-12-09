namespace GUI.UC
{
    partial class UC_ThongKe
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
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.bdthangB = new System.Windows.Forms.BindingSource(this.components);
            this.bdthangA = new System.Windows.Forms.BindingSource(this.components);
            this.chrBaoCaoSoLuongDangky = new DevExpress.XtraCharts.ChartControl();
            this.cbChart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.cbQuyThongKe = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.errorYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.bdthangC = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdthangB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdthangA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCaoSoLuongDangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdthangC)).BeginInit();
            this.SuspendLayout();
            // 
            // chrBaoCaoSoLuongDangky
            // 
            this.chrBaoCaoSoLuongDangky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chrBaoCaoSoLuongDangky.Legend.Name = "Default Legend";
            this.chrBaoCaoSoLuongDangky.Location = new System.Drawing.Point(0, 108);
            this.chrBaoCaoSoLuongDangky.Name = "chrBaoCaoSoLuongDangky";
            this.chrBaoCaoSoLuongDangky.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chrBaoCaoSoLuongDangky.Size = new System.Drawing.Size(1117, 437);
            this.chrBaoCaoSoLuongDangky.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Báo cáo Số lượng học sinh đăng ký";
            this.chrBaoCaoSoLuongDangky.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // cbChart
            // 
            this.cbChart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChart.FormattingEnabled = true;
            this.cbChart.Items.AddRange(new object[] {
            "Thống Kê Theo Lớp",
            "Thống kê Theo CLB"});
            this.cbChart.Location = new System.Drawing.Point(481, 57);
            this.cbChart.Name = "cbChart";
            this.cbChart.Size = new System.Drawing.Size(180, 25);
            this.cbChart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê theo";
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuLieu.Appearance.Options.UseFont = true;
            this.btnDuLieu.ImageOptions.Image = global::GUI.Properties.Resources.load_data_Chart_icon;
            this.btnDuLieu.Location = new System.Drawing.Point(698, 29);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(121, 36);
            this.btnDuLieu.TabIndex = 3;
            this.btnDuLieu.Text = "Load Dữ liệu";
            this.btnDuLieu.Click += new System.EventHandler(this.btnDuLieu_Click);
            // 
            // cbQuyThongKe
            // 
            this.cbQuyThongKe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyThongKe.FormattingEnabled = true;
            this.cbQuyThongKe.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbQuyThongKe.Location = new System.Drawing.Point(482, 19);
            this.cbQuyThongKe.Name = "cbQuyThongKe";
            this.cbQuyThongKe.Size = new System.Drawing.Size(60, 25);
            this.cbQuyThongKe.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(593, 18);
            this.txtNam.MaxLength = 4;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(68, 25);
            this.txtNam.TabIndex = 1;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(548, 19);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 19);
            this.lblNam.TabIndex = 8;
            this.lblNam.Text = "Năm";
            // 
            // errorYear
            // 
            this.errorYear.ContainerControl = this;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.cbQuyThongKe);
            this.Controls.Add(this.btnDuLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChart);
            this.Controls.Add(this.chrBaoCaoSoLuongDangky);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1117, 545);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdthangB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdthangA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCaoSoLuongDangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdthangC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chrBaoCaoSoLuongDangky;
        private System.Windows.Forms.ComboBox cbChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private System.Windows.Forms.BindingSource bdthangA;
        private System.Windows.Forms.BindingSource bdthangB;
        private System.Windows.Forms.ComboBox cbQuyThongKe;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ErrorProvider errorYear;
        private System.Windows.Forms.BindingSource bdthangC;
    }
}
