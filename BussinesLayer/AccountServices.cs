using DataLayer.InterFace;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class AccountServices
    {
        static IAccountRepository AccRepo;
        static AccountServices()
        {
            AccRepo = new AccountRepository();
        }
        public static bool CheckAccountexits(string inputAccount)
        {
            return AccRepo.CheckuserName(inputAccount);
        }
        public static GiaoVu LayThongtinGiaoVu(string inputAccount)
        {
            return AccRepo.LayThongtinGiaoVu(inputAccount);
        }
        public static void DoiMatKhau(string MatKhauMoi, string MaGiaoVu)
        {
            AccRepo.DoiMatKhau(MaGiaoVu, MatKhauMoi);
        }
        public static int ThayDoiThongTinTaiKhoan(string MaGiaoVu, string TenGiaoVu, string SDT, string Email, string TaiKhoan)
        {
            return AccRepo.DoiThongTinTaiKhoan(MaGiaoVu, TenGiaoVu, SDT, Email, TaiKhoan);
        }
        public static GiaoVu LayThongTinGiaoVuTheoMa(string MaGV)
        {
            return AccRepo.LayThongTinGiaoVuBangMaGiaoVu(MaGV);
        }
        public static List<GiaoVu> DanhSachGiaoVuCoNgoaiTru(string MaGV)
        {
            List<GiaoVu> AllGv = AccRepo.LayDanhSachGiaoVu();
            var DsGiaoVu = from gv in AllGv
                           where gv.MaGiaoVu != MaGV
                           select gv;
            return DsGiaoVu.ToList();
        }
        public static int ThemGiaoVu(string TenGiaoVu, string SDT, string Email, string TaiKhoan, string MatKhau)
        {
            return AccRepo.ThemGiaoVu(TenGiaoVu, SDT, Email, TaiKhoan, MatKhau);
        }
    }
}
