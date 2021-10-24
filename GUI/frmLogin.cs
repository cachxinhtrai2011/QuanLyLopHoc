using BussinesLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private int count = 0;
        GiaoVu gv = new GiaoVu();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void LoginAction()
        {
            if (AccountServices.CheckAccountexits(mttTaiKhoan.Text))
            {
                gv = AccountServices.LayThongtinGiaoVu(mttTaiKhoan.Text);
                if (gv.MatKhau == GenericServices.Encrypts(mttMatKhau.Text))
                {
                    Thread m = new Thread(ShowMainForm);
                    m.Start();
                    
                }
                else
                {
                    Thread x = new Thread(MatKhauCheck);
                    x.Start();
                }

            }
            else
            {
                Thread t = new Thread(Settextbox);
                t.Start();
            }
        }
        private void ShowMainForm()
        {
            try
            {
                if (btnLogin.InvokeRequired)
                {
                    btnLogin.Invoke(new Action(ShowMainForm));
                    return;
                }
                this.Hide();
                using (frmMain frm = new frmMain(gv))
                {
                    frm.ShowDialog();
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MatKhauCheck()
        {
            try
            {
                if (btnLogin.InvokeRequired)
                {
                    btnLogin.Invoke(new Action(MatKhauCheck));
                    return;
                }
                mttlab.Visible = true;
                mttlab.Text = "Sai Mật Khẩu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Settextbox()
        {
            try
            {
                if (btnLogin.InvokeRequired)
                {
                    btnLogin.Invoke(new Action(Settextbox));
                    return;
                }
                mttlab.Visible = true;
                mttlab.Text = "Sai Tài khoản";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mttMatKhau.Text) || !string.IsNullOrEmpty(mttTaiKhoan.Text))
            {
                if (count == 0)
                {
                    using (frmLoading frm = new frmLoading(LoginAction))
                    {
                        frm.ShowDialog(this);
                    }
                    count++;
                }
                else LoginAction();
                
                
            }
            else
            {
                mttlab.Visible = true;
                mttlab.Text = "Empty!!!";
            } 
        }

        private void mttCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(mttCheckBox.Checked)
            {
                Properties.Settings.Default.TaiKhoan = mttTaiKhoan.Text;
                Properties.Settings.Default.MatKhau = mttMatKhau.Text;
            }
            else
            {
                Properties.Settings.Default.TaiKhoan = null;
                Properties.Settings.Default.MatKhau = null;
            }
            Properties.Settings.Default.RememberMe = mttCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                mttMatKhau.Text = Properties.Settings.Default.MatKhau;
                mttTaiKhoan.Text = Properties.Settings.Default.TaiKhoan;
            }
            if (!string.IsNullOrEmpty(mttMatKhau.Text) && !string.IsNullOrEmpty(mttTaiKhoan.Text))
            {
                mttCheckBox.Checked = true;
            }
            else mttCheckBox.Checked = false;
            
        }
    }
}
