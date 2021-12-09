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
using Model;
using BussinesLayer;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace GUI.UC
{
    public partial class UC_QuanLyTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_QuanLyTaiKhoan _instance;
        bool indicatorIcon = true;
        public static UC_QuanLyTaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_QuanLyTaiKhoan(gvcurrent);
                return _instance;
            }
        }
        public static GiaoVu gvcurrent;
        public UC_QuanLyTaiKhoan(GiaoVu gv)
        {
            gvcurrent = gv;   
            InitializeComponent();
        }

        private void UC_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

            onload();
        }
        #region làm cột indicator STT
        private void gvGiaoVu_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void gvGiaoVu_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion
        public void onload()
        {
            List<GiaoVu> Ds = AccountServices.DanhSachGiaoVuCoNgoaiTru(gvcurrent.MaGiaoVu);
            bdDanhSachTaiKhoan.DataSource = Ds;
        }
        private void btnSuaThongTinTK_Click(object sender, EventArgs e)
        {
            Int32[] SelectedRowCollection = gvGiaoVu.GetSelectedRows();
            if(SelectedRowCollection.Length > 0)
            {
                GiaoVu CurrentSelected = bdDanhSachTaiKhoan.Current as GiaoVu;
                using (frmThongTinGiaoVu frm = new frmThongTinGiaoVu(CurrentSelected))
                {
                    frm.Size = new Size(530, 283);
                    frm.Controls.Remove(frm.lbPassword); frm.Controls.Remove(frm.lblcomfirmPassword);
                    frm.Controls.Remove(frm.btnThuchienThemhocsinh); frm.Controls.Remove(frm.txtComfirm); frm.Controls.Remove(frm.txtPassword);
                    frm.btnUpdate.Location = new Point(232, 199);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn gì sao mà xóa");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            GiaoVu CurrentSelected = bdDanhSachTaiKhoan.Current as GiaoVu;
            using (frmDoiMatKhau frm = new frmDoiMatKhau(CurrentSelected))
            {
                frm.txtPasswordCu.Text = GenericServices.Decrypts(CurrentSelected.MatKhau);
                frm.txtPasswordCu.Visible = false;
                frm.lblPasswordCu.Visible = false;
                frm.ShowDialog();
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            GiaoVu gv = new GiaoVu();
            using(frmThongTinGiaoVu frm = new frmThongTinGiaoVu(gv))
            {
                frm.Controls.Remove(frm.btnUpdate);
                frm.ShowDialog();
            }
        }
    }
}
