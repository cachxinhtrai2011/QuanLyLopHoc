using Dapper;
using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        public List<HoaDon> GetAllCurrent()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var DsHoaDonThangHienTai = from hd in db.HoaDons.AsNoTracking()
                                           where (hd.NgayTao.Value.Month == DateTime.Now.Month && hd.NgayTao.Value.Year == DateTime.Now.Year)
                                           select hd;
                return DsHoaDonThangHienTai.ToList();
            }
        }

        public List<HoaDon> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsHD = from hd in db.HoaDons.AsNoTracking()
                           select hd;
                return dsHD.ToList();
            }
        }

        public int UpdateHD(string MaHD)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaHD", MaHD);
                    return db.Execute("UpdateTinhTrangHoaDon", p, commandType: CommandType.StoredProcedure);

                }

            }
        }

        public void XoaDuLieuHoaDon(string MaHD)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaHoaDon", MaHD);
                    db.Execute("XoaDuLieuHoaDOn", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
