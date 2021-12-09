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
using DevExpress.XtraCharts;

namespace GUI.UC
{
    public partial class UC_ThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_ThongKe _instance;
        public static UC_ThongKe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongKe();
                return _instance;
            }
        }
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            if (cbChart.SelectedIndex < 0 || cbQuyThongKe.SelectedIndex < 0 || string.IsNullOrEmpty(txtNam.Text))
                MessageBox.Show("Vui lòng chọn các trường để load dữ liệu");
            else
            {

                chrBaoCaoSoLuongDangky.Series.Clear();
                int Thang = (cbQuyThongKe.SelectedIndex + 1) * 3;
                List<Series> DanhSachSeries = new List<Series>();
                DanhSachSeries.Add(new Series($"Tháng {(Thang - 2).ToString()}", ViewType.Bar));
                DanhSachSeries.Add(new Series($"Tháng {(Thang - 1).ToString()}", ViewType.Bar));
                DanhSachSeries.Add(new Series($"Tháng {Thang.ToString()}", ViewType.Bar));
                if (cbChart.SelectedIndex == 0)
                {
                    DataTable dtLA = LopDangKyServices.DanhsachLopDangKyVaSoHocSinh(Int32.Parse(txtNam.Text), Thang - 2);
                    DataTable dtLB = LopDangKyServices.DanhsachLopDangKyVaSoHocSinh(Int32.Parse(txtNam.Text), Thang - 1);
                    DataTable dtLC = LopDangKyServices.DanhsachLopDangKyVaSoHocSinh(Int32.Parse(txtNam.Text), Thang);
                    if (dtLA.Rows.Count != 0 || dtLB.Rows.Count != 0 || dtLC.Rows.Count != 0)
                    {
                        DanhSachSeries[0].DataSource = dtLA;
                        DanhSachSeries[1].DataSource = dtLB;
                        DanhSachSeries[2].DataSource = dtLC;
                        DanhSachSeries.ForEach(
                            x =>
                            {
                                chrBaoCaoSoLuongDangky.Series.Add(x);
                                x.ArgumentScaleType = ScaleType.Auto;
                                x.ArgumentDataMember = "TenVaMaLop";
                                x.ValueDataMembers.AddRange(new string[] { "Count" });
                            });
                    }
                    else MessageBox.Show("Không có dữ liệu nào");
                }
                else
                {
                    DataTable dtclbA = CLBServices.DanhSachCLBvaSoHocSinh(Int32.Parse(txtNam.Text), Thang - 2);
                    DataTable dtclbB = CLBServices.DanhSachCLBvaSoHocSinh(Int32.Parse(txtNam.Text), Thang - 1);
                    DataTable dtclbC = CLBServices.DanhSachCLBvaSoHocSinh(Int32.Parse(txtNam.Text), Thang);
                    if (dtclbA.Rows.Count != 0 || dtclbB.Rows.Count != 0 || dtclbC.Rows.Count != 0)
                    {
                        DanhSachSeries[0].DataSource = dtclbA;
                        DanhSachSeries[1].DataSource = dtclbB;
                        DanhSachSeries[2].DataSource = dtclbC;
                        DanhSachSeries.ForEach(
                            x =>
                            {
                                chrBaoCaoSoLuongDangky.Series.Add(x);
                                x.ArgumentScaleType = ScaleType.Auto;
                                x.ArgumentDataMember = "ID";
                                x.ValueDataMembers.AddRange(new string[] { "Count" });
                            });
                    }
                    else MessageBox.Show("khoong co data");
                }
            }
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (txtNam.Text.YearStringValidation())
            {
                errorYear.SetError(txtNam, "Yêu cầu điền đúng định dạng Năm");

            }
            else errorYear.SetError(txtNam, null);
        }
    }
}
