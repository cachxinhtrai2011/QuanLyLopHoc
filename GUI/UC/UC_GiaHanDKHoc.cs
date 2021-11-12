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
using Model;

namespace GUI.UC
{
    public partial class UC_GiaHanDKHoc : DevExpress.XtraEditors.XtraUserControl
    {
        CheckBox headerCheckBox = new CheckBox();
        private static UC_GiaHanDKHoc _instance;
        public static UC_GiaHanDKHoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_GiaHanDKHoc();
                return _instance;
            }
        }
        public UC_GiaHanDKHoc()
        {
            InitializeComponent();
            
        }
        private void UC_GiaHanDKHoc_Load(object sender, EventArgs e)
        {
            onload();
            AddCheckbox();
        }
        public void onload()
        {
            //try
            //{
                adgvdsHSGiaHanDK.AutoGenerateColumns = true;
                DataTable dt = HocSinhServices.LayDanhSachHocSinhDuDKGiaHanDangKyHoc();
                bdDsHSGiaHan.DataSource = dt;
                adgvdsHSGiaHanDK.CleanFilterAndSort();
                headerCheckBox.Checked = false;
            advancedDataGridViewSearchToolBar1.SetColumns(adgvdsHSGiaHanDK.Columns);
            if (adgvdsHSGiaHanDK.Columns.Count ==10)
            {
                adgvdsHSGiaHanDK.Columns["NgaySinh"].DisplayIndex = 4;
                adgvdsHSGiaHanDK.SetFilterDateAndTimeEnabled(adgvdsHSGiaHanDK.Columns[4], true);
                adgvdsHSGiaHanDK.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                adgvdsHSGiaHanDK.Columns["NgayNhapHoc"].DefaultCellStyle.Format = "d";
                adgvdsHSGiaHanDK.Columns["NgayNhapHoc"].HeaderText = "Nhập học";
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }
        #region Add all check columns
        private void AddCheckbox()
        {
            Point headerCellLocation = this.adgvdsHSGiaHanDK.GetCellDisplayRectangle(1, -1, true).Location;
            //Place the Header CheckBox in the Location of the Header Cell.
            headerCheckBox.Location = new Point(headerCellLocation.X + 35, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = clCheckBox.DefaultCellStyle.BackColor;
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.Click += HeaderCheckBox_Click;
            adgvdsHSGiaHanDK.Controls.Add(headerCheckBox);

            adgvdsHSGiaHanDK.DisableFilterAndSort(adgvdsHSGiaHanDK.Columns["clCheckBox"]);
            adgvdsHSGiaHanDK.DisableFilterAndSort(adgvdsHSGiaHanDK.Columns["clSTT"]);
        }
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            //Necessary to end the edit mode of the Cell.
            adgvdsHSGiaHanDK.EndEdit();

            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            foreach (DataGridViewRow row in adgvdsHSGiaHanDK.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells["clCheckBox"] as DataGridViewCheckBoxCell);
                checkBox.Value = headerCheckBox.Checked;
            }
        }
        private void adgvdsHSGiaHanDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in adgvdsHSGiaHanDK.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["clCheckBox"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }

        #endregion
        //Add STT columns
        private void adgvdsHSGiaHanDK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvdsHSGiaHanDK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in adgvdsHSGiaHanDK.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["clCheckBox"].Value) == true
                                                  select row).ToList();
            foreach (DataGridViewRow row in selectedRows)
            {
                foreach (DangKyHoc dk in HocSinhServices.DsLopDangKyCuaHocSinhGiaHan(row.Cells[2].Value.ToString()))
                {
                    DangKyHocServices.DangKyHoc(row.Cells[2].Value.ToString(), dk.LopDangKy);
                }
            }
            if (selectedRows.Count > 0)
            {
                MessageBox.Show($"Gia hạn thành công cho {selectedRows.Count.ToString()} học sinh");
                onload();
                UC_DKHOC.Instance.onload();
                UC_DKHOC.Instance.btnPickStd.PerformClick();
                UC_HuyDKHoc.Instance.onload();
                UC_HuyDKHoc.Instance.btnPickStd.PerformClick();

            }
            else
            {
                MessageBox.Show("xin hãy chọn học sinh gia hạn");
            }
        }

        private void advancedDataGridViewSearchToolBar1_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = adgvdsHSGiaHanDK.CurrentCell.ColumnIndex + 1 >= adgvdsHSGiaHanDK.ColumnCount;
                bool endrow = adgvdsHSGiaHanDK.CurrentCell.RowIndex + 1 >= adgvdsHSGiaHanDK.RowCount;

                if (endcol && endrow)
                {
                    startColumn = adgvdsHSGiaHanDK.CurrentCell.ColumnIndex;
                    startRow = adgvdsHSGiaHanDK.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : adgvdsHSGiaHanDK.CurrentCell.ColumnIndex + 1;
                    startRow = adgvdsHSGiaHanDK.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = adgvdsHSGiaHanDK.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = adgvdsHSGiaHanDK.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                adgvdsHSGiaHanDK.CurrentCell = c;
        }
    }
}
