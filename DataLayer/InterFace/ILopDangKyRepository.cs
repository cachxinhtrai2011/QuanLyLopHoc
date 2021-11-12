using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface ILopDangKyRepository
    {
        List<LopDangKy> LayDanhSachLopDangKy();
        int ThayDoiThongTinLopDangKy(string MaLopDK, string TenLopDK, string MaCLB, string NamHoc, decimal HocPhi, int LichHoc);
        int ThemThongTinLopDangKy(string TenLop, string MaCLB, string Namhoc, decimal HocPhi, int LichHoc);
    }
}
