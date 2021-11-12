using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.UC
{
    public partial class UC_About : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_About _instance;
        public static UC_About Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_About();
                return _instance;
            }
        }
        public UC_About()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
