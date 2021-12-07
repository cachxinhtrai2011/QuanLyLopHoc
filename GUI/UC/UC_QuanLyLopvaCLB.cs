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
using BussinesLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace GUI.UC
{
    public partial class UC_QuanLyLopvaCLB : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_QuanLyLopvaCLB _instance;
        bool indicatorIcon = true;
        public static UC_QuanLyLopvaCLB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_QuanLyLopvaCLB();
                return _instance;
            }
        }
        public UC_QuanLyLopvaCLB()
        {
            InitializeComponent();
        }

        private void UC_QuanLyLopvaCLB_Load(object sender, EventArgs e)
        {
            onload();
        }
        public void onload()
        {
            bddsLopDangKy.DataSource = LopDangKyServices.LayDanhSachToanBoLopDangKy();
        }

        private void gvDanhSachLopDangKy_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name == "clLichHoc")
            {
                e.DisplayText = "Thứ " + e.Value.ToString();
            }
        }

        #region Cột STT
        private void gvDanhSachLopDangKy_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvDanhSachLopDangKy_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            int[] RowIndexData = gvDanhSachLopDangKy.GetSelectedRows();
            
            if (RowIndexData.Length > 0)
            {
                DataRow rv = gvDanhSachLopDangKy.GetDataRow(RowIndexData[0]);
                if (!LopDangKyServices.CheckDangKyHienTaiCuaLop(rv[0].ToString()))
                {
                    using (frmCapNhatThongTinLopDangKy frm = new frmCapNhatThongTinLopDangKy(rv))
                    {
                        frm.Controls.Remove(frm.btnThemLopMoi);
                        frm.btnCapNhatTTlop.Location = new Point(182, 269);
                        frm.ShowDialog();
                    }
                }
                else MessageBox.Show("Lớp này đã có đăng ký trong tháng này nên không thể chỉnh sửa được");
            }
            else MessageBox.Show("Chưa có dòng nào được chọn nên không thể thực hiện chỉnh sửa");
        }

        private void btnThemLopMoi_Click(object sender, EventArgs e)
        {
            DataRow rv = null;
            using (frmCapNhatThongTinLopDangKy frm = new frmCapNhatThongTinLopDangKy(rv))
            {
                frm.Controls.Remove(frm.btnCapNhatTTlop);
                frm.btnThemLopMoi.Location = new Point(182, 269);
                frm.ShowDialog();
            }
        }

        private void btnDanhSachCLB_Click(object sender, EventArgs e)
        {
            using(frmDanhSachCLB frm = new frmDanhSachCLB())
            {
                frm.ShowDialog();
            }
        }
    }
}
