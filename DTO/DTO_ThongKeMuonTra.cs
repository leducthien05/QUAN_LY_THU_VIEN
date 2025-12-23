using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongKeMuonTra
    {
        public string LoaiPhieu { get; set; }
        public DateTime? NgayMuonTu { get; set; }
        public DateTime? NgayMuonDen { get; set; }
        public DTO_ThongKeMuonTra() { }
    }
}
