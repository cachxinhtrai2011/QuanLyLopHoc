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
    public partial class UC_LopHC : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_LopHC _instance;
        bool indicatorIcon = true;
        public static UC_LopHC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_LopHC();
                return _instance;
            }
        }
        public UC_LopHC()
        {
            InitializeComponent();
        }

        private void UC_LopHC_Load(object sender, EventArgs e)
        {
            onload();
        }
        public void onload()
        {
            bdLopHC.DataSource = LopHCServices.LayDanhSachLopHCVaSoLuongHS();
        }
        private void gvDanhSachLopHC_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.Name == "clSoLuongHS")
            {
                if (IsNullValue(e.Value))
                {
                    e.DisplayText = "không có học sinh";
                }
                else e.DisplayText = e.Value + " Học Sinh";
            }
        }
        private static bool IsNullValue(object value)
        {
            return value == null || String.IsNullOrEmpty(value.ToString()) || String.IsNullOrWhiteSpace(value.ToString());
        }

        #region Cột STT
        private void gvDanhSachLopHC_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvDanhSachLopHC_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion

        private void btnCapNhatLopHC_Click(object sender, EventArgs e)
        {
            Int32[] RowSelectData = gvDanhSachLopHC.GetSelectedRows();
            if (RowSelectData.Length > 0)
            {
                DataRow rv = gvDanhSachLopHC.GetDataRow(RowSelectData[0]);
                using (frmCapNhatLopHC frm = new frmCapNhatLopHC(rv))
                {
                    frm.ShowDialog();
                }
                
            }
        }

        private void btnThemLopHC_Click(object sender, EventArgs e)
        {
            DataRow rv = null;
            using(frmCapNhatLopHC frm = new frmCapNhatLopHC(rv))
            {
                frm.ShowDialog();
            }
        }

        private void btnNhapHSExcell_Click(object sender, EventArgs e)
        {
            int[] GetInDexSelect = gvDanhSachLopHC.GetSelectedRows();
            DataRow rv = gvDanhSachLopHC.GetDataRow(GetInDexSelect[0]);
            DialogResult resul = MessageBox.Show($"Bạn có muốn Thêm danh sách HS từ Excel cho Lớp Hành chính {rv[1].ToString()}", "Gợi ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (GetInDexSelect.Length > 0 && resul == DialogResult.Yes)
            {
                using (frmExcelLopHC frm = new frmExcelLopHC(rv[0].ToString()))
                {
                    frm.ShowDialog();
                }
            }
            

        }
    }
}
