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
    
    public static class LopHCServices
    {
        static ILopHCRepository LopHCRepo;
        static IHocSinhRepository HocSinhRepo;
        static LopHCServices()
        {
            LopHCRepo = new LopHCRepository();
            HocSinhRepo = new HocSinhRepository();
        }
        public static List<LopHanhChinh> LayDanhSachLopHanhChinh()
        {
            return LopHCRepo.GetAlls();
        }
        public static DataTable LayDanhSachLopHCVaSoLuongHS()
        {
            List<LopHanhChinh> dsLopHC = LopHCRepo.GetAlls();
            List<HocSinh> dsHS = HocSinhRepo.GetAlls();
            var dsLopHCVaSoHS = from hs in dsHS
                                select new
                                {
                                    hs.LopHC
                                } into x
                                group x by new { x.LopHC } into g
                                select new
                                {
                                    g.Key.LopHC,
                                    Soluong = g.Count()
                                };

            var dsComplete = dsLopHC.FullOuterJoin(dsLopHCVaSoHS.ToList(), a => a.MaLopHC, b=>b.LopHC, (a,b,MaLopHC) =>
                new
                {
                    a.MaLopHC,
                    a.TenLopHC,
                    a.NienKhoa,
                    a.TenGiaoVienChuNhiem,
                    b?.Soluong
                });
            return GenericServices.ToDataTable(dsComplete.ToList());

        }
        public static int CapNhatTTLopHC(string MaLopHC, string TenLopHC, string NienKhoa, string TenGiaoVienCN)
        {
            return LopHCRepo.CapNhatTTLopHC(MaLopHC, TenLopHC, NienKhoa, TenGiaoVienCN);
        }
        public static int ThemLopHCMoi(string TenLopHC, string NienKhoa, string TenGiaoVienCN)
        {
            return LopHCRepo.ThemLopHCMoi(TenLopHC, NienKhoa, TenGiaoVienCN);
        }
    }
}
