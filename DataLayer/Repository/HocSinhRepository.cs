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
    public class HocSinhRepository : IHocSinhRepository
    {
        public List<HocSinh> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsHS = from hs in db.HocSinhs.Include("LopHanhChinh").AsNoTracking()
                           select hs;
                return dsHS.ToList();
            }
        }

        public int ThemHocSinh(string TenHS, DateTime NgaySinh, string TenChaMe, string SDTChaMe, string DiaChi, string LopHC)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters(); p.Add("@TenHS", TenHS);
                    p.Add("@NgaySinh", NgaySinh.ToString("yyyy-MM-dd"));
                    p.Add("@TenChaMe", TenChaMe);
                    p.Add("@SDTChaMe", SDTChaMe);
                    p.Add("@DiaChi", DiaChi);
                    p.Add("@LopHC", LopHC);
                   return db.Execute("ThemHocSinh", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public int UpdateHocSinh(string MaHs, string TenHS, DateTime NgaySinh, string TenchaMe, string SDTChame, string Diachi, string LopHC)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@NgaySinh", NgaySinh.ToString("yyyy-MM-dd"));
                    p.Add("@TenHocSinh", TenHS);
                    p.Add("@MaHocSinh", MaHs);
                    p.Add("@TenChaMe", TenchaMe);
                    p.Add("@SDTChaMe", SDTChame);
                    p.Add("@DiaChi", Diachi);
                    p.Add("@LopHanhChinh", LopHC);
                    return db.Execute("UpdateTTHocSinh", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
