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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace GUI.UC
{
    public partial class UC_LICHSUHOADON : DevExpress.XtraEditors.XtraUserControl
    {
        bool indicatorIcon = true;
        private static UC_LICHSUHOADON _instance;
        public static UC_LICHSUHOADON Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_LICHSUHOADON();
                return _instance;
            }
        }
        public UC_LICHSUHOADON()
        {
            InitializeComponent();
        }
 

        private void UC_LICHSUHOADON_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            e.DisplayText = e.RowHandle.ToString();
        }

        private void btnLoadDataHD_Click(object sender, EventArgs e)
        {
            bdHoaDon.DataSource = HoaDonServices.LayDanhSachHoaDonTheoNamvaThang(dtpDuLieuHoaDon.Value.Year, dtpDuLieuHoaDon.Value.Month);
            if(dtpDuLieuHoaDon.Value.Year == DateTime.Now.Year && dtpDuLieuHoaDon.Value.Month == DateTime.Now.Month)
            {
                btnXoaDuLieuHoaDon.Enabled = false;
            }
            else
            {
                btnXoaDuLieuHoaDon.Enabled = true;
            }
        }
        #region làm cột indicator STT
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion
        private bool ExportExcel(string filename)
        {
            try
            {
                if(gridView1.FocusedRowHandle < 0)
                {

                }
                else
                {
                    SaveFileDialog.FileName = filename;
                    if(SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.ColumnPanelRowHeight = 20;
                        gridView1.OptionsPrint.AutoWidth = AutoSize;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = $"Hóa Đơn tháng {dtpDuLieuHoaDon.Value.Month.ToString()}-{dtpDuLieuHoaDon.Value.Year.ToString()}";
                       
                        ExportSettings.DefaultExportType = ExportType.Default;
                        gridView1.ExportToXlsx(SaveFileDialog.FileName, options);
                        MessageBox.Show("Xuất thành công");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcel("");
        }

        private void btnXoaDuLieuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                Int32[] selectedrowHandles = gridView1.GetSelectedRows();
                if (selectedrowHandles.Length > 0)
                {
                    DialogResult reslut = MessageBox.Show("Nếu bạn xóa dữ liệu hóa đơn ở đây thì toàn bộ dữ liệu đăng ký học cũng bị xóa Theo.\n Bạn chắc chắn chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (reslut == DialogResult.Yes)
                    {
                        for (int i = 0; i < selectedrowHandles.Length; i++)
                        {
                            int selectRownHandle = selectedrowHandles[i];
                            DataRow gv = gridView1.GetDataRow(selectRownHandle);
                            HoaDonServices.XoaDuLieuHoaDon(gv[1].ToString());
                        }
                        btnLoadDataHD.PerformClick();
                        //UC_DKHOC.Instance.onload();
                        //UC_DKHOC.Instance.btnPickStd.PerformClick();
                        //UC_HuyDKHoc.Instance.onload();
                        //UC_HuyDKHoc.Instance.btnPickStd.PerformClick();
                        UC_GiaHanDKHoc.Instance.onload();
                    }

                }
                else MessageBox.Show("Chưa chọn gì không thể xóa");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
