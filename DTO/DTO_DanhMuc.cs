using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhMuc
    {
        public string ID_DM { get; set; }
        public string TenDM { get; set; }
        public string ID_DanhMucCha { get; set; }
        public DTO_DanhMuc() { }
        public DTO_DanhMuc(string ID_DM, string TenDM, string ID_DanhMucCha)
        {
            this.ID_DM = ID_DM;
            this.TenDM = TenDM;
            this.ID_DanhMucCha = ID_DanhMucCha;
        }
    }
}
