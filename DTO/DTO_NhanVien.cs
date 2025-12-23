using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_NhanVien
    {
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string ID_BoPhan { get; set; }
        public string ID_ChucVu { get; set; }
        public string TrangThai { get; set; }
        public DTO_NhanVien() { }
        public DTO_NhanVien(string ID_NV, string TenNV, string SDT, string Email, string ID_BoPhan, string ID_ChucVu, string TrangThai)
        {
            this.ID_NV = ID_NV;
            this.TenNV = TenNV;
            this.SDT = SDT;
            this.Email = Email;
            this.ID_BoPhan = ID_BoPhan;
            this.ID_ChucVu = ID_ChucVu;
            this.TrangThai = TrangThai;
        }
    }
}
