using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NXB
    {
        public string ID_NXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public DTO_NXB() { }
        public DTO_NXB(string ID_NXB, string TenNXB, string DiaChi)
        {
            this.ID_NXB = ID_NXB;
            this.TenNXB = TenNXB;
            this.DiaChi = DiaChi;
        }
    }
}
