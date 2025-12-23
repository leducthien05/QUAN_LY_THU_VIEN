using System.Data;
using DTO;

namespace DAL
{
    public class ThongKeDocGia_DAL : Connect
    {  
        public ThongKeDocGia_DAL() { }
        public DataTable Load_DocGia()
        {
            return LoadData("SELECT * FROM DOCGIA");
        }
        public DataTable ThongKe_DocGia(DTO_ThongKeDocGia dk)
        {
            string sql = @"
                            SELECT *
                            FROM DOCGIA
                            WHERE 1 = 1";
            if (!string.IsNullOrEmpty(dk.TenDocGia))
            {
                sql += " AND TenDG LIKE N'%" + dk.TenDocGia + "%'";
            }
            if (!string.IsNullOrEmpty(dk.TrangThai))
            {
                sql += " AND TrangThai = N'" + dk.TrangThai + "'";
            }
            return LoadData(sql);
        }
    }
}
