using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DocGia
    {
        public string ID_DocGia { get; set; }
        public string TenDG { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string TrangThai { get; set; }
        public DTO_DocGia() { }
        public DTO_DocGia(string ID_DocGia, string TenDG, string SDT, string Email, string DiaChi, string TrangThai)
        {
            this.ID_DocGia = ID_DocGia;
            this.TenDG = TenDG;
            this.SDT = SDT;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.TrangThai = TrangThai;
        }
    }
}
