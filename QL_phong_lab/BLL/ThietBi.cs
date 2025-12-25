using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_phong_lab.BLL
{
    public class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string MoTa { get; set; }
        public ThietBi(string maThietBi, string tenThietBi, string moTa)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            MoTa = moTa;
        }
        public ThietBi() { }
    }
}
