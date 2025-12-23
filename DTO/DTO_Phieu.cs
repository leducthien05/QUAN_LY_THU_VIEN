using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phieu
    {
        public string ID_Phieu { get; set; }
        public string LoaiPhieu { get; set; }
        public string ID_DG { get; set; }
        public string ID_NV { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayTraThucTe { get; set; }
        public DTO_Phieu() { }
        public DTO_Phieu(string ID_Phieu, string LoaiPhieu, string ID_DG, string ID_NV, DateTime NgayMuon, DateTime NgayTra, string GhiChu, DateTime NgayTraThucTe)
        {
            this.ID_Phieu = ID_Phieu;
            this.LoaiPhieu = LoaiPhieu;
            this.ID_DG = ID_DG;
            this.ID_NV = ID_NV;
            this.NgayMuon = NgayMuon;
            this.NgayTra = NgayTra;
            this.GhiChu = GhiChu;
            this.NgayTraThucTe = NgayTraThucTe;
        }
    }
}
