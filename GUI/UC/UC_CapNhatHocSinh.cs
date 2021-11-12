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
    public partial class UC_CapNhatHocSinh : DevExpress.XtraEditors.XtraUserControl
    {
        bool indicatorIcon = true;
        private static UC_CapNhatHocSinh _instance;
        public static UC_CapNhatHocSinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CapNhatHocSinh();
                return _instance;
            }
        }
        public UC_CapNhatHocSinh()
        {
            InitializeComponent();
        }
        string TenLopHC = null;
        string MaHocSinh = null;
        private void btnAddHocSinh_Click(object sender, EventArgs e)
        {
            using (frmCapNhatHocSinh frm = new frmCapNhatHocSinh(TenLopHC, MaHocSinh))
            {
                frm.btnThemHS.Enabled = true;
                frm.ShowDialog();
                
            }
        }
        public void onload()
        {
            bdHocSinh.DataSource = HocSinhServices.GetAlls();

        }
        public void UC_CapNhatHocSinh_Load(object sender, EventArgs e)
        {
            onload();
        }
        #region Tạo cột indicator STT
        private void gridViewHocSinh_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gridViewHocSinh_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion

        private void btnAddEcxel_Click(object sender, EventArgs e)
        {
            using (frmExcelHS frm = new frmExcelHS())
            {
                frm.ShowDialog();
            }
        }

        private void btnUpdateHocSinh_Click(object sender, EventArgs e)
        {
            int[] RowIndexData = gridViewHocSinh.GetSelectedRows();
            
            if (RowIndexData.Length > 0)
            {
                DataRow rv = gridViewHocSinh.GetDataRow(RowIndexData[0]);
                using (frmCapNhatHocSinh frm = new frmCapNhatHocSinh(rv[4].ToString(), rv[0].ToString()))
                {
                    frm.btnUpdate.Enabled = true;
                    frm.Text = "Cập nhật thông tin học sinh";
                    frm.datNgaySinh.Value = Convert.ToDateTime(rv[2]);
                    frm.txtTenHS.Text = rv[1].ToString();
                    frm.txtTenChaMe.Text = rv[5].ToString();
                    frm.txtSDTLienHe.Text = rv[7].ToString();
                    frm.txtDiaChi.Text = rv[6].ToString();
                    frm.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh cần cập nhật thông tin");
            }
        }
    }
}
