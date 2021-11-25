using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface ICLBRepository
    {
        List<CLB> GetAlls();
        int UpdateTTCLB(string MaCLB, string TenCLB);

        int ThemCLBMoi(string TenCLB);
    }
}
