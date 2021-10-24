using BussinesLayer;
using GUI.UC;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        GiaoVu _gv;
        public frmMain(GiaoVu gv)
        {
            _gv = gv;
            InitializeComponent();
        }


        private void btnMDangKyHoc_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_DKHOC.Instance))
            {
                this.Controls.Add(UC_DKHOC.Instance);
                UC_DKHOC.Instance.Dock = DockStyle.Fill;
                UC_DKHOC.Instance.BringToFront();
                
            }
            else
            {
                UC_DKHOC.Instance.BringToFront();
                
            }
        }

        private void btnHuyDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_HuyDKHoc.Instance))
            {
                using (frmKey frm = new frmKey())
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        this.Controls.Add(UC_HuyDKHoc.Instance);
                        UC_HuyDKHoc.Instance.Dock = DockStyle.Fill;
                        UC_HuyDKHoc.Instance.BringToFront();
                    }
                }
            }
            else
                UC_HuyDKHoc.Instance.BringToFront();
        }

        private void btnGiaHanDangKyHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_GiaHanDKHoc.Instance))
            {
                this.Controls.Add(UC_GiaHanDKHoc.Instance);
                UC_GiaHanDKHoc.Instance.Dock = DockStyle.Fill;
                UC_GiaHanDKHoc.Instance.BringToFront();
            }
            else
            {
                UC_GiaHanDKHoc.Instance.BringToFront();
            }
        }

        private void btnLichSuHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_LICHSUHOADON.Instance))
            {
                this.Controls.Add(UC_LICHSUHOADON.Instance);
                UC_LICHSUHOADON.Instance.Dock = DockStyle.Fill;
                UC_LICHSUHOADON.Instance.BringToFront();
            }
            else
            {
                UC_LICHSUHOADON.Instance.BringToFront();
            }
        }

        private void btnCapNhapTTHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_CapNhatHocSinh.Instance))
            {
                this.Controls.Add(UC_CapNhatHocSinh.Instance);
                UC_CapNhatHocSinh.Instance.Dock = DockStyle.Fill;
                UC_CapNhatHocSinh.Instance.BringToFront();
            }
            else
            {
                UC_CapNhatHocSinh.Instance.BringToFront();
                
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn đăng Xuất ra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                using (frmLogin frm = new frmLogin())
                {
                    frm.ShowDialog();
                }
                this.Close();
            }
            else return;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            onload();

        }
        private void onload()
        {
            var LastName = _gv.TenGiaoVu.Split(' ').Last();
            string TenGiaoVu = LastName.ToString();
            btnDownDropAccount.Text = $"Xin Chào: {LastName}";
            if (!this.Controls.Contains(UC_About.Instance))
            {
                this.Controls.Add(UC_About.Instance);

                UC_About.Instance.Dock = DockStyle.Fill;
                UC_About.Instance.BringToFront();
            }
            else
            {
                UC_About.Instance.BringToFront();

            }
        }


        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmDoiMatKhau frm = new frmDoiMatKhau(_gv))
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_ThongKe.Instance))
            {
                this.Controls.Add(UC_ThongKe.Instance);
               
                UC_ThongKe.Instance.Dock = DockStyle.Fill;
                UC_ThongKe.Instance.BringToFront();
            }
            else
            {
                UC_ThongKe.Instance.BringToFront();

            }
        }
        private void btnDownDropAccount_Click(object sender, EventArgs e)
        {
            using (frmThongTinGiaoVu frm = new frmThongTinGiaoVu(_gv))
            {
                frm.Size = new Size(530, 283);
                frm.Controls.Remove(frm.lbPassword); frm.Controls.Remove(frm.lblcomfirmPassword);
                frm.Controls.Remove(frm.btnThuchienThemhocsinh); frm.Controls.Remove(frm.txtComfirm); frm.Controls.Remove(frm.txtPassword);
                frm.btnUpdate.Location = new Point(232, 199);
                frm.FormClosing += Frm_FormClosing;
                frm.ShowDialog();
            }
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gv = AccountServices.LayThongTinGiaoVuTheoMa(_gv.MaGV);
            onload();
        }

        private void btnAccountManaGer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_QuanLyTaiKhoan.gvcurrent = _gv;
            if(!this.Controls.Contains(UC_QuanLyTaiKhoan.Instance))
            {
                this.Controls.Add(UC_QuanLyTaiKhoan.Instance);
                UC_QuanLyTaiKhoan.Instance.Dock = DockStyle.Fill;
                UC_QuanLyTaiKhoan.Instance.onload();
                UC_QuanLyTaiKhoan.Instance.BringToFront();
                
            }
            else
            {
                UC_QuanLyTaiKhoan.Instance.onload();
                UC_QuanLyTaiKhoan.Instance.BringToFront();
            }
        }

        private void btnInformation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_About.Instance))
            {
                this.Controls.Add(UC_About.Instance);

                UC_About.Instance.Dock = DockStyle.Fill;
                UC_About.Instance.BringToFront();
            }
            else
            {
                UC_About.Instance.BringToFront();

            }
        }

        private void btnCLB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_QuanLyLopvaCLB.Instance))
            {
                this.Controls.Add(UC_QuanLyLopvaCLB.Instance);
                UC_QuanLyLopvaCLB.Instance.Dock = DockStyle.Fill;
                UC_QuanLyLopvaCLB.Instance.BringToFront();
            }
            else
            {
                UC_QuanLyLopvaCLB.Instance.BringToFront();
            }
        }

        private void btnQuanLyLopHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_LopHC.Instance))
            {
                this.Controls.Add(UC_LopHC.Instance);
                UC_LopHC.Instance.Dock = DockStyle.Fill;
                UC_LopHC.Instance.BringToFront();
            }
            else
            {
                UC_LopHC.Instance.BringToFront();
            }
        }
    }
}
