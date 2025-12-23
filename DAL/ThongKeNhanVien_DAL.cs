using System.Data;
using DTO;

namespace DAL
{
    public class ThongKeNhanVien_DAL : Connect
    {
        public ThongKeNhanVien_DAL() { }
        public DataTable Load_NhanVien()
        {
            return LoadData("SELECT * FROM NHANVIEN");
        }
        public DataTable ThongKe_NhanVien(DTO_ThongKeNhanVien dk)
        {
            string sql = @"
                SELECT 
                    nv.MaNV,
                    nv.TenNV,
                    cv.TenChucVu,
                    bp.TenBoPhan,
                    nv.TrangThai
                FROM NHANVIEN nv
                INNER JOIN CHUCVU cv ON nv.MaCV = cv.MaCV
                INNER JOIN BOPHAN bp ON nv.MaBP = bp.MaBP
                WHERE 1 = 1";

            // Tên nhân viên
            if (!string.IsNullOrEmpty(dk.TenNV))
            {
                sql += " AND nv.TenNV LIKE N'%" + dk.TenNV + "%'";
            }

            // LỌC THEO ID CHỨC VỤ
            if (!string.IsNullOrEmpty(dk.ID_ChucVu))
            {
                sql += " AND nv.ID_ChucVu = '" + dk.ID_ChucVu + "'";
            }

            // LỌC THEO ID BỘ PHẬN
            if (!string.IsNullOrEmpty(dk.ID_BoPhan))
            {
                sql += " AND nv.ID_BoPhan = '" + dk.ID_BoPhan + "'";
            }

            // Trạng thái
            if (!string.IsNullOrEmpty(dk.TrangThai))
            {
                sql += " AND nv.TrangThai = N'" + dk.TrangThai + "'";
            }

            return LoadData(sql);
        }
    }
}
