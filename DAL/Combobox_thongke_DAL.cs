using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Combobox_thongke_DAL: Connect
    {
        public DataTable getDM()
        {
            string sql = "SELECT * FROM DANHMUC";
            return LoadData(sql);
        }
        public DataTable getCV()
        {
            string sql = "SELECT * FROM CHUCVU";
            return LoadData(sql);
        }
        public DataTable getPB()
        {
            string sql = "SELECT * FROM BOPHAN";
            return LoadData(sql);

        }

    }

}
