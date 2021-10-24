namespace GUI
{
    partial class frmKey
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnenter = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(29, 22);
            this.txtKey.MaxLength = 25;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(170, 25);
            this.txtKey.TabIndex = 0;
            // 
            // btnenter
            // 
            this.btnenter.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Appearance.Options.UseFont = true;
            this.btnenter.Location = new System.Drawing.Point(215, 22);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(88, 25);
            this.btnenter.TabIndex = 1;
            this.btnenter.Text = "Enter";
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(115, 65);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 15);
            this.lblThongBao.TabIndex = 2;
            // 
            // frmKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 89);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKey";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private DevExpress.XtraEditors.SimpleButton btnenter;
        private System.Windows.Forms.Label lblThongBao;
    }
}