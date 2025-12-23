using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BUS
{
    public class Combobox_ThongKE_BUS
    {
        Combobox_thongke_DAL dal = new Combobox_thongke_DAL();
        public DataTable getDM()
        {
            return dal.getDM();
        }
        public DataTable getCV()
        {
            return dal.getCV();
        }
        public DataTable getPB()
        {
            return dal.getPB();
        }
    }
}
