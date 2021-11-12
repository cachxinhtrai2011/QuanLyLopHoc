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
    public class LopHCRepository : ILopHCRepository
    {
        public int CapNhatTTLopHC(string MaLopHC, string TenLopHC, string NienKhoa, string TenGiaoVienCN)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaLopHC", MaLopHC);
                    p.Add("@TenLopHC", TenLopHC);
                    p.Add("@NienKhoa", NienKhoa);
                    p.Add("@TenGiaoVienCN", TenGiaoVienCN);
                    return db.Execute("CapNhatTTLopHC", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<LopHanhChinh> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsLopHC = from lophc in db.LopHanhChinhs
                              select lophc;
                return dsLopHC.ToList();
            }
        }

        public int ThemLopHCMoi(string TenLopHC, string NienKhoa, string TenGiaoVienCN)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@TenLopHC", TenLopHC);
                    p.Add("@NienKhoa", NienKhoa);
                    p.Add("@TenGiaoVienChuNhiem", TenGiaoVienCN);
                    return db.Execute("ThemLopHC", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
