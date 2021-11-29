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
    public class AccountRepository : IAccountRepository
    {
        public bool CheckuserName(string username)
        {
            using (MamNonBK context = new MamNonBK())
            {
                var TaiKhoan = from tk in context.GiaoVus.AsNoTracking()
                                  where tk.TaiKhoan == username
                                  select tk.TaiKhoan;
                if (!TaiKhoan.ToList().Any())
                    return false;
                else return true;

            }
        }

        public void DoiMatKhau(string MaGiaoVu, string MatKhauMoi)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    //Đổi mật khẩu
                    var p = new DynamicParameters();
                    p.Add("@MatKhauMoi", MatKhauMoi);
                    p.Add("@MaGV", MaGiaoVu);
                    db.Execute("DoiMatKhau", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public int DoiThongTinTaiKhoan(string MaGiaoVU, string TenGiaoVu, string SDT, string Email, string TaiKhoan)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@TenGiaoVu", TenGiaoVu);
                    p.Add("@Email", Email);
                    p.Add("@DienThoai", SDT);
                    p.Add("@TaiKhoan", TaiKhoan);
                    p.Add("@MaGiaoVu", MaGiaoVU);
                    return db.Execute("UpdateTTGiaoVu", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<GiaoVu> LayDanhSachGiaoVu()
        {
            using (MamNonBK context = new MamNonBK())
            {
                var DsGiaoVu = from gv in context.GiaoVus.AsNoTracking()
                               select gv;
                return DsGiaoVu.ToList();
            }
        }

        public GiaoVu LayThongtinGiaoVu(string TaiKhoan)
        {
            
                using (MamNonBK context = new MamNonBK())
                {
                    var TTGiaoVu = from gv in context.GiaoVus.AsNoTracking()
                                   where TaiKhoan == gv.TaiKhoan
                                   select gv;
                    return TTGiaoVu.ToList().FirstOrDefault();
               
                }
        }

        public GiaoVu LayThongTinGiaoVuBangMaGiaoVu(string MaGiaoVu)
        {
            using (MamNonBK context = new MamNonBK())
            {
                var TTGiaoVu = from gv in context.GiaoVus.AsNoTracking()
                               where MaGiaoVu == gv.MaGV
                               select gv;
                return TTGiaoVu.ToList().FirstOrDefault();
            }
        }

        public int ThemGiaoVu(string TenGiaoVu, string SDT, string Email, string TaiKhoan, string MatKhau)
        {
            
            using(MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@TenGiaoVu", TenGiaoVu);
                    p.Add("@TaiKhoan", TaiKhoan);
                    p.Add("@MatKhau", MatKhau);
                    p.Add("@Email", Email);
                    p.Add("@SDT", SDT);
                    return db.Execute("ThemTaiKhoanGiaoVu", p, commandType: CommandType.StoredProcedure);
                }
            }


        }
    }
}
