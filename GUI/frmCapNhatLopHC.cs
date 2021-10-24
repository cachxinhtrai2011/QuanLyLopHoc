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
    public partial class frmCapNhatLopHC : DevExpress.XtraEditors.XtraForm
    {
        DataRow _rv;
        string OldName = null;
        public frmCapNhatLopHC(DataRow rv)
        {
            _rv = rv;
            InitializeComponent();
        }

        private void btnSuaTTLopHC_Click(object sender, EventArgs e)
        {
            bool CheckValidation = true;
            int Change = 0;
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
                Change = LopHCServices.CapNhatTTLopHC(txtTenLopHC.Tag.ToString(), txtTenLopHC.Text, txtNienKhoa.Text, txtTenGiaoVienCN.Text);
                if (Change > 0)
                {
                    MessageBox.Show($"Cập nhật thành công cho lớp {txtTenLopHC.Text}");
                    UC_LopHC.Instance.onload();
                    UC_DKHOC.Instance.onload();
                    UC_DKHOC.Instance.btnPickStd.PerformClick();
                    if (UC_DKHOC.Instance.adgvHocSinhDuDK.FilterString.Contains(OldName))
                    {
                        UC_DKHOC.Instance.adgvHocSinhDuDK.CleanFilterAndSort();
                    }
                    UC_HuyDKHoc.Instance.btnPickStd.PerformClick();
                    UC_CapNhatHocSinh.Instance.onload();
                }
                else MessageBox.Show("Cập nhật không thể thành công");
            }
        }

        private void frmCapNhatLopHC_Load(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.TextChanged += Tb_TextChanged;
            }
            if (_rv != null)
            {
                this.Controls.Remove(btnADdThemLopMoi);
                btnSuaTTLopHC.Location = new Point(178, 169);
                OldName = _rv[1].ToString();
                txtTenLopHC.Text = _rv[1].ToString();
                txtTenLopHC.Tag = _rv[0].ToString();
                txtNienKhoa.Text = _rv[2].ToString();
                txtTenGiaoVienCN.Text = _rv[3].ToString();
            }
            else
            {
                this.Controls.Remove(btnSuaTTLopHC);
                btnADdThemLopMoi.Location = new Point(178, 169);
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnADdThemLopMoi_Click(object sender, EventArgs e)
        {
            bool CheckValidation = true;
            int Change = 0;
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
                Change = LopHCServices.ThemLopHCMoi(txtTenLopHC.Text, txtNienKhoa.Text, txtTenGiaoVienCN.Text);
                if (Change > 0)
                {
                    MessageBox.Show($"Thêm Thành công lớp {txtTenLopHC.Text}");
                    UC_LopHC.Instance.onload();
                    UC_DKHOC.Instance.onload();
                    UC_HuyDKHoc.Instance.btnPickStd.PerformClick();
                    UC_CapNhatHocSinh.Instance.onload();
                }
                else MessageBox.Show("Thêm dữ liệu không thành công");
            }
        }
    }
}