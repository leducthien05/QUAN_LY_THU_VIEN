using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        public string MaTG { get; set; }
        public string TenTG { get; set; }
        public string QuocGia { get; set; }
        public TacGia() { }
        public TacGia(string maTG, string tenTG, string quocGia)
        {
            this.MaTG = maTG;
            this.TenTG = tenTG;
            this.QuocGia = quocGia;
        }
    }
}
