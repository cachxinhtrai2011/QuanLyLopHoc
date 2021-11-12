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

namespace GUI.UC
{
    public partial class UC_HuyDKHoc : DevExpress.XtraEditors.XtraUserControl
    {
        CheckBox headerCheckBox = new CheckBox();
        string MaLopDangKy = "null";
        private static UC_HuyDKHoc _instance;
        public static UC_HuyDKHoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HuyDKHoc();
                return _instance;
            }
        }
        public UC_HuyDKHoc()
        {
            InitializeComponent();
        }

        private void UC_HuyDKHoc_Load(object sender, EventArgs e)
        {
            onload();
            AddCheckbox();
        }
        public void onload()
        {
            adgvLopDangKyH.AutoGenerateColumns = false;
            adgvLopDangKyH.DisableFilterAndSort(clLSTT);
            adgvLopDangKyH.DisableFilterAndSort(clMaLopDk);
            adgvLopDangKyH.DisableFilterAndSort(clSoLuongHocSinh);
            bddsLopTheoHS.DataSource = LopDangKyServices.cacLopcoHocSinhdangKy();
        }

        

        #region Add All check
        private void AddCheckbox()
        {
            Point headerCellLocation = this.adgvHocSinhHuyDK.GetCellDisplayRectangle(1, -1, true).Location;
            //Place the Header CheckBox in the Location of the Header Cell.
            headerCheckBox.Location = new Point(headerCellLocation.X + 35, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = clChonHS.DefaultCellStyle.BackColor;
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.Click += HeaderCheckBox_Click;
            adgvHocSinhHuyDK.Controls.Add(headerCheckBox);
            adgvHocSinhHuyDK.AutoGenerateColumns = true;
            adgvHocSinhHuyDK.FilterAndSortEnabled = true;
            adgvHocSinhHuyDK.DisableFilterAndSort(adgvHocSinhHuyDK.Columns["clChonHS"]);
            adgvHocSinhHuyDK.DisableFilterAndSort(adgvHocSinhHuyDK.Columns["clHSSTT"]);
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            //Necessary to end the edit mode of the Cell.
            adgvHocSinhHuyDK.EndEdit();

            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            foreach (DataGridViewRow row in adgvHocSinhHuyDK.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells["clChonHS"] as DataGridViewCheckBoxCell);
                checkBox.Value = headerCheckBox.Checked;
            }
        }
        private void adgvHocSinhHuyDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in adgvHocSinhHuyDK.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["clChonHS"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }

        #endregion

        private void btnChonLop_Click(object sender, EventArgs e)
        {

            adgvHocSinhHuyDK.CleanFilterAndSort();
            headerCheckBox.Checked = false;
            foreach (DataGridViewRow row in adgvLopDangKyH.SelectedRows)
            {
                MaLopDangKy = row.Cells[1].Value.ToString();
            }
            adgvHocSinhHuyDK.AutoGenerateColumns = true;
            DataTable dt = HocSinhServices.LayHocSinhDaDangKyTheoMaLopDangKy(MaLopDangKy);
            bdHocSinh.DataSource = dt;
            if (adgvHocSinhHuyDK.Columns.Count == 10)
            {
                adgvHocSinhHuyDK.Columns["NgaySinh"].DisplayIndex = 4;
                adgvHocSinhHuyDK.SetFilterDateAndTimeEnabled(adgvHocSinhHuyDK.Columns[4], true);
                adgvHocSinhHuyDK.Columns[4].HeaderText = "Ngày sinh";
                adgvHocSinhHuyDK.Columns["NgayNhapHoc"].DefaultCellStyle.Format = "d";
                adgvHocSinhHuyDK.Columns["NgayNhapHoc"].HeaderText = "Nhập học";
            }              
        }
        #region Tạo cột STT
        private void adgvLopDangKyH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvLopDangKyH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }
        private void adgvHocSinhHuyDK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvHocSinhHuyDK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT

        }
        #endregion

        #region Sự Kiện Check Box Sort và Filter
        private void adgvHocSinhHuyDK_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            headerCheckBox.Checked = false;
        }

        private void adgvHocSinhHuyDK_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            headerCheckBox.Checked = false;
        }
        #endregion

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in adgvHocSinhHuyDK.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["clChonHS"].Value) == true
                                                  select row).ToList();
            foreach (DataGridViewRow row in selectedRows)
            {
                DangKyHocServices.HuyDangKyhoc(row.Cells[2].Value.ToString(), MaLopDangKy);
            }
            if (selectedRows.Count > 0)
            {
                MessageBox.Show($"Hủy Thành công cho {selectedRows.Count.ToString()} học sinh");
                onload();
                btnPickStd.PerformClick();
                UC_DKHOC.Instance.onload();
                UC_DKHOC.Instance.btnPickStd.PerformClick();
                UC_GiaHanDKHoc.Instance.onload();
            }
            
        }
    }
}
