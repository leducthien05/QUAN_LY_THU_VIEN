using System;

namespace DTO
{
    public class DTO_ThongKeSach
    {
        // Tên
        public string TenSach { get; set; }
        public string TenTG { get; set; }
        public string TenNXB { get; set; }
        public string TenDM { get; set; }

        // Số lượng
        public int? SoLuongTu { get; set; }
        public int? SoLuongDen { get; set; }

        // Tồn kho
        public int? TonKhoTu { get; set; }
        public int? TonKhoDen { get; set; }

        // Giá
        public float? GiaTu { get; set; }
        public float? GiaDen { get; set; }

        // NXB
        public int? NamTu { get; set; }
        public int? NamDen { get; set; }

        public DTO_ThongKeSach() { }
    }
}
