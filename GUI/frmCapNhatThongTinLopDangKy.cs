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
using BussinesLayer;
using GUI.UC;

namespace GUI
{
    public partial class frmCapNhatThongTinLopDangKy : DevExpress.XtraEditors.XtraForm
    {
        DataRow _TTLop;
        public frmCapNhatThongTinLopDangKy(DataRow TTLop)
        {
            _TTLop = TTLop;
            InitializeComponent();
        }

        private void frmCapNhatThongTinLopDangKy_Load(object sender, EventArgs e)
        {
            cbCLB.DataSource = CLBServices.LayDanhSachCLB();
            cbCLB.DisplayMember = "TenCLB";
            cbCLB.ValueMember = "MaCLB";
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.TextChanged += Tb_TextChanged;
            }
            txtHocPhi.Text = _TTLop[2].ToString();
            txtTenLop.Text = _TTLop[1].ToString();
            txtLichHoc.Text = _TTLop[3].ToString();
            txtNamHoc.Text = _TTLop[6].ToString();
            cbCLB.SelectedIndex = cbCLB.FindStringExact(_TTLop[4].ToString());
            
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            switch (tb.Name)
            {
                case "txtNamHoc":
                    {
                        if (tb.Text.YearStringValidation())
                        {
                            errorProvider.SetError(tb, "Sai định dạng năm");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                //case "txtHocPhi":
                //    {
                //        if (!tb.Text.All(Char.IsDigit))
                //        {
                //            errorProvider.SetError(tb, "Phải điền vào chỉ có số mà thôi");
                //        }
                //        else errorProvider.SetError(tb, null);
                //        break;
                //    }
                case "txtLichHoc":
                    {
                        if (!tb.Text.All(char.IsDigit))
                        {
                            errorProvider.SetError(tb, "Phải điền vào chỉ có số mà thôi");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                default:
                    errorProvider.SetError(tb, null);
                    break;
            }
        }

        private void btnCapNhatTTlop_Click(object sender, EventArgs e)
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
                change = LopDangKyServices.CapNhatThongTinLopDangky(_TTLop[0].ToString(), txtTenLop.Text, cbCLB.SelectedValue.ToString(), txtNamHoc.Text, decimal.Parse(txtHocPhi.Text), int.Parse(txtLichHoc.Text));
                if (change > 0)
                {
                    MessageBox.Show($"Cập nhật thành công cho lớp {txtTenLop.Text}");
                    UC_QuanLyLopvaCLB.Instance.onload();
                    UC_DKHOC.Instance.btnPickStd.PerformClick();
                }
                else MessageBox.Show("Cập nhật thất bại");
            }
            else MessageBox.Show("Có trường bị sai định dạng hoặc đang bị để trống");
        }

        private void btnThemLopMoi_Click(object sender, EventArgs e)
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
                change = LopDangKyServices.ThemLopDangKyMoi(txtTenLop.Text, cbCLB.SelectedValue.ToString(), txtNamHoc.Text, decimal.Parse(txtHocPhi.Text), int.Parse(txtLichHoc.Text));
                if (change > 0)
                {
                    MessageBox.Show($"Thêm thành công lớp {txtTenLop.Text}");
                    UC_QuanLyLopvaCLB.Instance.onload();
                    UC_DKHOC.Instance.btnPickStd.PerformClick();
                }
                else MessageBox.Show("Thêm không thành công");
            }
            else MessageBox.Show("có trường sai định dạng hoặc bị để trống");
        }
    }
}