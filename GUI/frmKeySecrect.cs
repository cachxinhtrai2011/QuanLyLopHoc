using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class frmKey : DevExpress.XtraEditors.XtraForm
    {
        public frmKey()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if(txtKey.Text == "bachkhoa2019")
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
                this.Close();
            }
            else
            {
                lblThongBao.Text = "Sai Key rồi";
            }
        }
    }
}