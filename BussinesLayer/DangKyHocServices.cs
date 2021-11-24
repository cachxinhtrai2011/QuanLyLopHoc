using DataLayer.InterFace;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class DangKyHocServices
    {
        static IDangKyHocRepository dkHocrepo;
        static DangKyHocServices()
        {
            dkHocrepo = new DangKyHocRepository();
        }
        public static void DangKyHoc(string MaHS, string MaLopDangKy)
        {
            dkHocrepo.DangKyMoi(MaHS, MaLopDangKy);
        }
        public static void HuyDangKyhoc(string MaHS, string MaLopDangKy)
        {
            dkHocrepo.HuyDangKy(MaHS, MaLopDangKy);
        }
            
    }
}
