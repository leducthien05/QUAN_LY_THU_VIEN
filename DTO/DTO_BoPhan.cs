using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BoPhan
    {
        public string ID_BoPhan { get; set; }
        public string TenBoPhan { get; set; }
        public DTO_BoPhan() { }
        public DTO_BoPhan(string ID_BoPhan, string TenBoPhan)
        {
            this.ID_BoPhan = ID_BoPhan;
            this.TenBoPhan = TenBoPhan;
        }
    }
}
