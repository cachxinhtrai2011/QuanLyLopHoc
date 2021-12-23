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
    public class CLBRepository : ICLBRepository
    {
        public List<CLB> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsCLB = from clb in db.CLBs
                            select clb;
                return dsCLB.ToList();
            }
        }

        public int ThemCLBMoi(string TenCLB)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@TenCLB", TenCLB);
                    return db.Execute("ThemCLB", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public int UpdateTTCLB(string MaCLB, string TenCLB)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaCLB ", MaCLB);
                    p.Add("@TenCLB", TenCLB);
                    return db.Execute("UpdateTTCLB", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
