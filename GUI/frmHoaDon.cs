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
using GUI.RePort;
using System.Globalization;
using BussinesLayer;
using GUI.UC;

namespace GUI
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        DataRowView _hs;
        DataTable _dt;
        DataTable _hd;
        public frmHoaDon(DataTable dt, DataRowView hs, DataTable hd)
        {
            InitializeComponent();
            _hs = hs;
            _dt = dt;
            _hd = hd;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LopDangKyReportBindingSource.DataSource = _dt;
            DateTime dat = (DateTime)_hs["NgaySinh"];
            DateTime datHD = (DateTime)_hd.Rows[0][1];
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pMaHocSinh",_hs["MaHS"].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTenHS", _hs["TenHS"].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgaySinh", dat.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)),
                new Microsoft.Reporting.WinForms.ReportParameter("pTenLopHC", _hs["TenLopHC"].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTenChaMe", _hs["TenChaMe"].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSDTChaMe", _hs["SDTChaMe"].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pMaHD", _hd.Rows[0][0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pHDNgayTao", datHD.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture))


            };
            this.reportViewer1.LocalReport.SetParameters(p);

            this.reportViewer1.RefreshReport();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            string MaHD = (string)_hd.Rows[0][0];
            int Daupdate = HoaDonServices.UpdateTTInHoaDon(MaHD);
            UC_DKHOC.Instance.onload();

        }
    }
}