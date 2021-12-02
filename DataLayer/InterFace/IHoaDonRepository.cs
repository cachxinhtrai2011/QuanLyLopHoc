using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface IHoaDonRepository
    {
        List<HoaDon> GetAlls();
        void XoaDuLieuHoaDon(string MaHD);
        int UpdateHD(string MaHD);
        List<HoaDon> GetAllCurrent();
    }
}
