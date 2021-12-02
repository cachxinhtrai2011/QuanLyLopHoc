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
    public static class HoaDonServices
    {
        static IHoaDonRepository HDrepo;
        static IDangKyHocRepository DkHocRepo;
        static IHocSinhRepository HsRepo;
        static ILopDangKyRepository LDKRepo;
        static HoaDonServices()
        {
            HDrepo = new HoaDonRepository();
            DkHocRepo = new DangKyHocRepository();
            HsRepo = new HocSinhRepository();
            LDKRepo = new LopDangKyRepository();

        }
        public static DataTable LayDanhSachHoaDonTheoNamvaThang(int Nam, int Thang)
        {
            List<DangKyHoc> DsDkHoc = DkHocRepo.GetAlls();
            List<HoaDon> DsHoaDon = HDrepo.GetAlls();
            List<HocSinh> dsHS = HsRepo.GetAlls();
            List<LopDangKy> dsLDK = LDKRepo.LayDanhSachLopDangKy();
            var IdHoaDonvaCount = from hs in dsHS
                                  join hd in DsHoaDon on hs.MaHS equals hd.HocSinh
                                  join dk in DsDkHoc on hd.MaHD equals dk.HoaDon
                                  join ldk in dsLDK on dk.LopDangKy equals ldk.MaLopDangKy
                                  where (dk.NgayDangKy.Month == Thang && dk.NgayDangKy.Year == Nam)
                                  select new
                                  {
                                      hd.MaHD,
                                      hs.MaHS,
                                      hs.TenHS,
                                      hs.NgaySinh,
                                      hs.NgayNhapHoc,
                                      hs.LopHanhChinh.TenLopHC,
                                      ldk.HocPhi,
                                      hd.TinhTrang
                                      
                                  } into x
                                  group x by new { x.MaHS } into g
                                  select new
                                  {
                                      MaHocSinh = g.Key.MaHS,
                                      MaHoaDon = g.First().MaHD,
                                      TenHocSinh = g.First().TenHS,
                                      NgaySinhCuaHS = g.First().NgaySinh,
                                      NgayNhapHocCuaHS = g.First().NgayNhapHoc,
                                      TenLopHanhChinh = g.First().TenLopHC,
                                      TinhTrangHocPhi = g.First().TinhTrang,
                                      SoluongLopDangKy = g.Count(),
                                      TongHocPhi = g.Sum(m=>m.HocPhi)
                                      
                                  };
            return GenericServices.ToDataTable(IdHoaDonvaCount.ToList());

        }
        public static DataTable LayDanhSachHoaDonTheoMaHocSinh(string MaHS)
        {
            var dsHS = from hs in HsRepo.GetAlls()
                       join hd in HDrepo.GetAlls() on hs.MaHS equals hd.HocSinh
                       where (hd.NgayTao.Value.Month == DateTime.Now.Month && hd.NgayTao.Value.Year == DateTime.Now.Year && MaHS == hs.MaHS)
                       select new
                       {
                           hd.MaHD,
                           hd.NgayTao,
                           hd.TinhTrang
                       };
            return GenericServices.ToDataTable(dsHS.ToList());
        }
        public static void XoaDuLieuHoaDon(string MaHD)
        {
            HDrepo.XoaDuLieuHoaDon(MaHD);
        }
        public static int UpdateTTInHoaDon(string MaHD)
        {
            return HDrepo.UpdateHD(MaHD);
        }

    }
}
