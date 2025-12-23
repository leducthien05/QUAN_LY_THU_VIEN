using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        public string ID_ChucVu { get; set; }
        public string TenChucVu { get; set; }
        public DTO_ChucVu() { }
        public DTO_ChucVu(string ID_ChucVu, string TenChucVu)
        {
            this.ID_ChucVu = ID_ChucVu;
            this.TenChucVu = TenChucVu;
        }
    }
}
