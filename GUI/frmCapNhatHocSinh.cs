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
    public partial class frmCapNhatHocSinh : DevExpress.XtraEditors.XtraForm
    {
        string _TenLopHC = null;
        string _MaHocSinh = null;
        
        public frmCapNhatHocSinh(string TenLopHC, string MaHocSinh)
        {
            _TenLopHC = TenLopHC;
            _MaHocSinh = MaHocSinh;
            InitializeComponent();
        }

        private void frmCapNhatHocSinh_Load(object sender, EventArgs e)
        {
            onload();
            
        }
        public void onload()
        {
            cbLopHC.DataSource = LopHCServices.LayDanhSachLopHanhChinh();
            cbLopHC.DisplayMember = "TenLopHC";
            cbLopHC.ValueMember = "MaLopHC";
            if (!string.IsNullOrEmpty(_TenLopHC))
            {
                cbLopHC.SelectedIndex = cbLopHC.FindStringExact(_TenLopHC);
            }
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
                case "txtTenHS":
                    {
                        if (tb.Text.VietNameseNameValidation() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Sai dinh dạng Tên");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtSDTLienHe":
                    {
                        if (tb.Text.PhoneVietNamValidation() || tb.Text.Length > 16)
                        {
                            errorProvider.SetError(tb, "Sai dinh dang SDT roi");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtTenChaMe":
                    {
                        if (tb.Text.VietNameseNameValidation() || tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Sai Định dạng Tên");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                case "txtDiaChi":
                    {
                        if (tb.Text.Length > 255)
                        {
                            errorProvider.SetError(tb, "Địa chỉ quá dài rồi");
                        }
                        else errorProvider.SetError(tb, null);
                        break;
                    }
                default:
                    errorProvider.SetError(tb, null);
                    break;
            }
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            bool CheckValidation = true ;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if(!string.IsNullOrEmpty(errorProvider.GetError(tb)) || string.IsNullOrEmpty(tb.Text))
                {
                    CheckValidation = false;
                    break;
                }

            }
            if (CheckValidation)
            {
                if (HocSinhServices.ThemHocSinhVaoHeThong(txtTenHS.Text, datNgaySinh.Value, txtTenChaMe.Text, txtSDTLienHe.Text, txtDiaChi.Text, cbLopHC.SelectedValue.ToString()) > 0)
                {
                    UC_CapNhatHocSinh.Instance.onload();
                    UC_DKHOC.Instance.onload();
                    UC_LopHC.Instance.onload();
                    MessageBox.Show("Thêm thành công");
                    txtTenHS.Clear();
                    txtDiaChi.Clear();
                    txtSDTLienHe.Clear();
                    txtTenChaMe.Clear();
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi CSDL");
                }
            }
            else MessageBox.Show("Không được Có trường bị để trống hoặc sai định dạng");

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
                change = HocSinhServices.UpdateTTHocSinh(_MaHocSinh, txtTenHS.Text, datNgaySinh.Value, txtTenChaMe.Text, txtSDTLienHe.Text, txtDiaChi.Text, cbLopHC.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("các trường không được để trống hoặc sai định dạng");
            }
            if (change == 0)
            {
                MessageBox.Show("Không có thông tin nào mới để cập nhật");
            }
            else
            {
                UC_CapNhatHocSinh.Instance.onload();
                UC_LopHC.Instance.onload();
                UC_DKHOC.Instance.onload();
                UC_DKHOC.Instance.adgvHocSinhDuDK.CleanFilterAndSort();
                MessageBox.Show("Đã cập nhật thành công");
            }
        }

        private void datNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (datNgaySinh.NamHocValidation())
            {
                MessageBox.Show("Tuổi chưa hợp lệ");
                
            }
            
        }
    }
}