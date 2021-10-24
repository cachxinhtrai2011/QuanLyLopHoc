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
using GUI.UC;

namespace GUI
{
    public partial class frmThongTinGiaoVu : DevExpress.XtraEditors.XtraForm
    {
        GiaoVu _gv = new GiaoVu();
        public frmThongTinGiaoVu(GiaoVu gv)
        {
            _gv = gv;
            InitializeComponent();
        }

        private void frmThongTinGiaoVu_Load(object sender, EventArgs e)
        {
            txtEmail.Text = _gv.Email;
            txtTaiKhoan.Text = _gv.TaiKhoan;
            txtTenGiaovu.Text = _gv.TenGiaoVu;
            txtSDT.Text = _gv.DienThoai;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.TextChanged += Tb_TextChanged;
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            switch(tb.Name)
            {
                case "txtTenGiaovu":
                    {
                        if (tb.Text.VietNameseNameValidation() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Sai dinh dạng Tên");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtEmail":
                    {
                        if (tb.Text.EmailValidation() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Sai định dạng Email");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtSDT":
                    {
                        if (tb.Text.PhoneVietNamValidation() || tb.Text.Length > 16)
                        {
                            errorProvider.SetError(tb, "Sai số điện thoại rồi");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtTaiKhoan":
                    {
                        if (tb.Text.AccountandPasswordValidaion() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Tài Khoản không được có khoảng trắng");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtPassword":
                    {
                        if (tb.Text.AccountandPasswordValidaion() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Mật khẩu không được có khoảng trống");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                default:
                    errorProvider.SetError(tb, null);
                    break;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int change = 0;
            bool CheckValidation = true;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(tb)) || string.IsNullOrEmpty(tb.Text))
                {
                    CheckValidation = false;
                    break;
                }

            }
            if (CheckValidation)
            {
                change = AccountServices.ThayDoiThongTinTaiKhoan(_gv.MaGV, txtTenGiaovu.Text, txtSDT.Text, txtEmail.Text, txtTaiKhoan.Text);
                if (change > 0)
                {
                    MessageBox.Show($"Đã cập nhật thành công cho Giáo vụ có Mã {_gv.MaGV}");
                    if (UC_QuanLyTaiKhoan.gvcurrent != null)
                    {
                        UC_QuanLyTaiKhoan.Instance.onload();
                    }

                }
                else
                {
                    MessageBox.Show("Thực hiện không thành công do lỗi từ phía CSDL");
                }
            }
            else
            {
                MessageBox.Show("Có trường bị để trống hoặc bị sai định dạng");
            }
        }

        private void btnThuchienThemhocsinh_Click(object sender, EventArgs e)
        {
            int change = 0;
            bool CheckValidation = true;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(tb)) || string.IsNullOrEmpty(tb.Text))
                {
                    CheckValidation = false;
                    break;
                }

            }
            if(CheckValidation)
            {
                if (txtComfirm.Text.Equals(txtPassword.Text) && !AccountServices.CheckAccountexits(txtTaiKhoan.Text))
                {
                    int changeaddevent = AccountServices.ThemGiaoVu(txtTenGiaovu.Text, txtSDT.Text, txtEmail.Text, txtTaiKhoan.Text, GenericServices.Encrypts(txtPassword.Text));
                    if (changeaddevent > 0)
                    {
                        MessageBox.Show("Thêm thành công giáo vụ");
                        UC_QuanLyTaiKhoan.Instance.onload();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ phí CSDL");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không giống mật khẩu hoặc Account đã tồn tại");
                }
            }
            else MessageBox.Show("có trường bị sai định dạng hoặc đang bị để trống");

        }
    }
}