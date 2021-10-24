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
using ExcelDataReader;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using BussinesLayer;
using GUI.UC;

namespace GUI
{
    public partial class frmExcelLopHC : DevExpress.XtraEditors.XtraForm
    {
        DataTableCollection tableCollection;
        bool indicatorIcon = true;
        string _MaLopHC = null;
        public frmExcelLopHC(string MaLopHC)
        {
            _MaLopHC = MaLopHC;
            InitializeComponent();
        }

        private void frmExcelLopHC_Load(object sender, EventArgs e)
        {

        }

        private void btnTimFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (opfDexcel.ShowDialog() == DialogResult.OK)
                {
                    txtLink.Text = opfDexcel.FileName;
                    using (var stream = File.Open(opfDexcel.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);//add sheet to combobox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            string[] columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
            if (columnNames.Length != 5 || string.Compare(columnNames[0], "Tên Học Sinh", true) != 0 || string.Compare(columnNames[1], "Ngày Sinh", true) != 0 || string.Compare(columnNames[2], "Tên cha mẹ", true) != 0 ||
                string.Compare(columnNames[3], "SĐT Cha Mẹ", true) != 0 || string.Compare(columnNames[4], "Địa chỉ", true) != 0)
            {
                MessageBox.Show("Định dạng bảng không phù hợp");
            }
            else
            {
                bdExcell.DataSource = dt;
                clTenHS.FieldName = columnNames[0];
                clNgaySinh.FieldName = columnNames[1];
                clTenChaMe.FieldName = columnNames[2];
                clSDTChaMe.FieldName = columnNames[3];
                clAddress.FieldName = columnNames[4];
                
            }
        }

        #region Cột STT
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
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 30;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            int[] RowIndexData = gridView1.GetSelectedRows();
            int SoHocSinhDaThem = 0;
            if (RowIndexData.Length > 0)
            {
                for (int i = 0; i < RowIndexData.Length; i++)
                {
                    int selectRownHandle = RowIndexData[i];
                    DataRow gv = gridView1.GetDataRow(selectRownHandle);
                    SoHocSinhDaThem += HocSinhServices.ThemHocSinhVaoHeThong(gv[0].ToString(), Convert.ToDateTime(gv[1].ToString()), gv[2].ToString(), gv[3].ToString(), gv[4].ToString(), _MaLopHC);
                }
                if (SoHocSinhDaThem > 0)
                {
                    MessageBox.Show($"Đã Thêm vào {SoHocSinhDaThem.ToString()}");
                    UC_CapNhatHocSinh.Instance.onload();
                    UC_DKHOC.Instance.onload();
                    UC_DKHOC.Instance.btnPickStd.PerformClick();
                    UC_LopHC.Instance.onload();
                    gridView1.DeleteSelectedRows();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bất cứ học sinh nào");
            }
        }
    }
}