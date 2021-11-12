using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface ILopHCRepository
    {
        List<LopHanhChinh> GetAlls();
        int CapNhatTTLopHC(string MaLopHC, string TenLopHC, string NienKhoa, string TenGiaoVienCN);

        int ThemLopHCMoi(string TenLopHC, string NienKhoa, string TenGiaoVienCN);
    }
}
