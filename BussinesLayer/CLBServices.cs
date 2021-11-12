using DataLayer.InterFace;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class CLBServices
    {
        static IDangKyHocRepository dkHocRepo;
        static ILopDangKyRepository LopDangKyRepo;
        static ICLBRepository CLBRepo;
        static CLBServices()
        {
            dkHocRepo = new DangKyHocRepository();
            LopDangKyRepo = new LopDangKyRepository();
            CLBRepo = new CLBRepository();
        }
        public static DataTable DanhSachCLBvaSoHocSinh(int Nam, int Thang)
        {
            List<DangKyHoc> dsDKHoc = dkHocRepo.GetAlls();
            List<LopDangKy> dsLopDK = LopDangKyRepo.LayDanhSachLopDangKy();
            List<CLB> dsCLB = CLBRepo.GetAlls();
            var MaCLBvaCount = from dk in dsDKHoc
                               join ldk in dsLopDK on dk.LopDangKy equals ldk.MaLopDangKy
                               join clb in dsCLB on ldk.CLB equals clb.MaCLB
                               group clb by new
                               {
                                   ID = clb.MaCLB + " - " + clb.TenCLB,
                                   Thang = dk.NgayDangKy.Month,
                                   Nam = dk.NgayDangKy.Year
                               }
                               into g
                               where (g.Key.Thang == Thang && g.Key.Nam == Nam)
                               select new
                               {
                                   ID = g.Key.ID,
                                   Count = g.Count()
                               };
            return GenericServices.ToDataTable(MaCLBvaCount.ToList());

        }
        public static List<CLB> LayDanhSachCLB()
        {
            return CLBRepo.GetAlls();
            
        }
        public static int UpdateTTCLB(string MaCLB, string TenCLB)
        {
            return CLBRepo.UpdateTTCLB(MaCLB, TenCLB);
        }
        public static int ThemCLB(string TenCLB)
        {
            return CLBRepo.ThemCLBMoi(TenCLB);
        }
    }
}
