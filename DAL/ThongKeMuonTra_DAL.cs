using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThongKeMuonTra_DAL: Connect
    {
        public ThongKeMuonTra_DAL() { }
        public DataTable Load_PhieuMuonTra()
        {
            return LoadData("SELECT * FROM PHIEU");
        }
        public DataTable ThongKeMuonTra(DTO_ThongKeMuonTra dk)
        {
            string sql = @"
                            SELECT *
                            FROM PHIEU pm
                            INNER JOIN DOCGIA dg ON pm.ID_DG = dg.ID_DocGia
                            WHERE 1 = 1";
            if (!string.IsNullOrEmpty(dk.LoaiPhieu))
            {
                sql += " AND dg.TenDG LIKE N'%" + dk.LoaiPhieu + "%'";
            }
            if (dk.NgayMuonTu.HasValue)
            {
                if (dk.NgayMuonDen.HasValue)
                    sql += " AND pm.NgayMuon BETWEEN '" + dk.NgayMuonTu.Value.ToString("yyyy-MM-dd") + "' AND '" + dk.NgayMuonDen.Value.ToString("yyyy-MM-dd") + "'";
                else
                    sql += " AND pm.NgayMuon >= '" + dk.NgayMuonTu.Value.ToString("yyyy-MM-dd") + "'";
            }
            return LoadData(sql);
        }
    }
}
