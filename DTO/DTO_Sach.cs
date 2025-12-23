using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        public string ID_Sach { get; set; }
        public string TenSach { get; set; }
        public string ID_TG { get; set; }
        public string ID_NXB { get; set; }
        public int NXB { get; set; }
        public int SoLuong { get; set; }
        public int TonKho { get; set; }
        public string ID_DM { get; set; }
        public float GiaSach { get; set; }
        public DTO_Sach() { }
        public DTO_Sach(string ID_Sach,string TenSach,string ID_TG,string ID_NXB,int NXB,int SoLuong,int TonKho,string ID_DM,float GiaSach)

        {
            this.ID_Sach = ID_Sach;
            this.TenSach = TenSach;
            this.ID_TG = ID_TG;
            this.ID_NXB = ID_NXB;
            this.NXB = NXB;
            this.SoLuong = SoLuong;
            this.TonKho = TonKho;
            this.ID_DM = ID_DM;
            this.GiaSach = GiaSach;
        }
    }
}
