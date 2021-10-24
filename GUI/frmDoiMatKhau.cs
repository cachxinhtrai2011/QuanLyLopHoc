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
using Model;
using BussinesLayer;

namespace GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        GiaoVu _gv = new GiaoVu();
        public frmDoiMatKhau(GiaoVu gv)
        {
            _gv = gv;
            InitializeComponent();
        }
        

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassWordMoi.Text) || string.IsNullOrEmpty(txtPasswordCu.Text) || string.IsNullOrEmpty(txtComFirm.Text))
            {
                MessageBox.Show("Có trường bị để trống");
            }
            else
            {
                if(txtPassWordMoi.Text.Equals(txtComFirm.Text))
                {
                    if (!txtPasswordCu.Text.Equals(txtPassWordMoi.Text))
                    {
                        if (txtPasswordCu.Text.Equals(GenericServices.Decrypts(_gv.MatKhau)))
                        {
                            AccountServices.DoiMatKhau(GenericServices.Encrypts(txtComFirm.Text), _gv.MaGV);
                            MessageBox.Show("Đổi mật khẩu thành công");
                            this.Hide();
                            this.Close();
                        }
                        else MessageBox.Show("Điền sai mật khẩu hiện thời");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và cũ không được giống nhau");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng điền mật khẩu comfirm giống nhau");
                }
            }
        }
    }
}