using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface IAccountRepository
    {
        bool CheckuserName(string username);
        GiaoVu LayThongtinGiaoVu(string TaiKhoan);
        void DoiMatKhau(string MaGiaoVu, string MatKhauMoi);
        int DoiThongTinTaiKhoan(string MaGiaoVU, string TenGiaoVu, string SDT, string Email, string TaiKhoan);
        GiaoVu LayThongTinGiaoVuBangMaGiaoVu(string MaGiaoVu);
        List<GiaoVu> LayDanhSachGiaoVu();
        int ThemGiaoVu(string TenGiaoVu, string SDT, string Email, string TaiKhoan, string MatKhau);

        
    }
}
