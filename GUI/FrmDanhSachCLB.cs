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
using Model;
using GUI.UC;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class frmDanhSachCLB : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachCLB()
        {
            InitializeComponent();
        }
        bool indicatorIcon = true;
        private void frmDanhSachCLB_Load(object sender, EventArgs e)
        {
            onload();
        }
        private void onload()
        {
            bdCLB.DataSource = CLBServices.LayDanhSachCLB();
        }

        private void btnThemCLB_Click(object sender, EventArgs e)
        {
            txtTenCLB.Enabled = true;
            txtTenCLB.Clear();
            btnCOmfirmThem.Enabled = true;
            btnComfirmEdit.Enabled = false;
            
        }

        private void btnSuaCLB_Click(object sender, EventArgs e)
        {
            int[] SelectedRowCollection = gvCLB.GetSelectedRows();
            CLB clb = bdCLB.Current as CLB;
            if (SelectedRowCollection.Length > 0)
            {
                txtTenCLB.Enabled = true;
                txtTenCLB.Text = clb.TenCLB;
                txtTenCLB.Tag = clb.MaCLB;
                btnComfirmEdit.Enabled = true;
                btnCOmfirmThem.Enabled = false;
            }
            else MessageBox.Show("Chưa chọn gì sao mà sửa");
        }

        private void btnCOmfirmThem_Click(object sender, EventArgs e)
        {
            int Change = 0;
            Change = CLBServices.ThemCLB(txtTenCLB.Text);
            if (Change > 0)
            {
                MessageBox.Show($"Thêm thành công CLB {txtTenCLB.Text}");
                onload();
                UC_QuanLyLopvaCLB.Instance.onload();
                UC_DKHOC.Instance.btnPickStd.PerformClick();
                btnCOmfirmThem.Enabled = false;
            }
            else MessageBox.Show("Thêm không thành công");
        }

        private void btnComfirmEdit_Click(object sender, EventArgs e)
        {
            int Change = 0;
            Change = CLBServices.UpdateTTCLB(txtTenCLB.Tag.ToString(), txtTenCLB.Text);
            if (Change > 0)
            {
                MessageBox.Show("Sửa Tên CLB thành công");
                onload();
                UC_QuanLyLopvaCLB.Instance.onload();
                UC_DKHOC.Instance.btnPickStd.PerformClick();
                btnComfirmEdit.Enabled = false;
            }
            else MessageBox.Show("Lỗi không thể cập nhật Vào CSDL");
        }

        #region Cột STT
        private void gvCLB_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvCLB_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 40;
        }
        #endregion
    }
}