using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface IHocSinhRepository
    {
        List<HocSinh> GetAlls();
        int ThemHocSinh(string TenHS, DateTime NgaySinh, string TenChaMe, string SDT, string DiaChi, string LopHC);
        int UpdateHocSinh(string MaHs, string TenHS, DateTime NgaySinh, string TenchaMe, string SDTChame, string Diachi, string LopHC);
    }
}
