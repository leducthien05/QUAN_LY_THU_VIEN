using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTiet_Phieu
    {
        public string ID_ChiTiet { get; set; }
        public string ID_Phieu { get; set; }
        public string ID_Sach { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrangTra { get; set; }
        public DTO_ChiTiet_Phieu() { }
        public DTO_ChiTiet_Phieu(string ID_ChiTiet, string ID_Phieu, string ID_Sach, int SoLuong, string TinhTrangTra)
        {
            this.ID_ChiTiet = ID_ChiTiet;
            this.ID_Phieu = ID_Phieu;
            this.ID_Sach = ID_Sach;
            this.SoLuong = SoLuong;
            this.TinhTrangTra = TinhTrangTra;
        }
    }
}
