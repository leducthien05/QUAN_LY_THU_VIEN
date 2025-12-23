namespace DTO
{
    public class DTO_ThongKeDocGia
    {
        public string TenDocGia { get; set; }
        public string TrangThai { get; set; }
        public int? SoSachMuonTu { get; set; }
        public int? SoSachMuonDen { get; set; }

        public int? SoSachMatTu { get; set; }
        public int? SoSachMatDen { get; set; }

        public DTO_ThongKeDocGia() { }
    }
}
