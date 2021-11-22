using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface IDangKyHocRepository
    {
        List<DangKyHoc> GetAlls();
        void DangKyMoi(string MaHS, string MaLopDangKy);
        void HuyDangKy(string MaHS, string MaLopDangKy);
        List<DangKyHoc> GetAllsCurrent();
    }
}
