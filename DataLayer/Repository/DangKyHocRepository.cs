using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataLayer.Repository
{
    public class DangKyHocRepository : IDangKyHocRepository
    {
        public void DangKyMoi(string MaHS, string MaLopDangKy)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    //Tạo hóa đơn
                    var p = new DynamicParameters(); p.Add("@MaHocSinh", MaHS);
                    db.Execute("InsertHoaDon", p, commandType: CommandType.StoredProcedure);
                    //Đăng ký học
                    var q = new DynamicParameters(); q.Add("@LopDK", MaLopDangKy); q.Add("@HocSinh", MaHS);
                    db.Execute("DangKyHocProc", q, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<DangKyHoc> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsDK = from dk in db.DangKyHocs.AsNoTracking()
                           select dk;
                return dsDK.ToList();
            }
        }

        public List<DangKyHoc> GetAllsCurrent()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var DsDKhocThangHienTai = from dkhoc in db.DangKyHocs.AsNoTracking()
                              where (dkhoc.NgayDangKy.Year == DateTime.Now.Year && dkhoc.NgayDangKy.Month == DateTime.Now.Month)
                              select dkhoc;
                return DsDKhocThangHienTai.ToList();
                              
            }
        }

        public void HuyDangKy(string MaHS, string MaLopDangKy)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters(); p.Add("@MaHocSinh", MaHS);
                    p.Add("@LopDangKy", MaLopDangKy);
                    db.Execute("HuyDangKyHoc", p, commandType: CommandType.StoredProcedure);
                    
                }
            }
        }
    }
}
