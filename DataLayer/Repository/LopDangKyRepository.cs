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
    public class LopDangKyRepository : ILopDangKyRepository
    {


        public List<LopDangKy> LayDanhSachLopDangKy()
        {
            List<LopDangKy> DsLopDK = new List<LopDangKy>();
            using (MamNonBK db = new MamNonBK())
            {
                DsLopDK = (from ds in db.LopDangKies.Include("CLB1").AsNoTracking()
                           select ds).ToList();

                return DsLopDK;
            }
        }

        public int ThayDoiThongTinLopDangKy(string MaLopDK, string TenLopDK, string MaCLB, string NamHoc, decimal HocPhi, int LichHoc)
        {
            using(MamNonBK context = new MamNonBK())
            {
                using(IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaLopDangKy", MaLopDK);
                    p.Add("@TenLopDangKy", TenLopDK);
                    p.Add("@MaCLB", MaCLB);
                    p.Add("@NamHoc", NamHoc);
                    p.Add("@HocPhi", HocPhi);
                    p.Add("@LichHoc", LichHoc);
                    return db.Execute("UpdateTTLopDangKy", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public int ThemThongTinLopDangKy(string TenLop, string MaCLB, string Namhoc, decimal HocPhi, int LichHoc)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@TenLopDangKy", TenLop);
                    p.Add("@HocPhi", HocPhi);
                    p.Add("@NamHoc", Namhoc);
                    p.Add("@LichHoc", LichHoc);
                    p.Add("@MaCLB", MaCLB);
                    return db.Execute("ThemLopDangKyMoi", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
