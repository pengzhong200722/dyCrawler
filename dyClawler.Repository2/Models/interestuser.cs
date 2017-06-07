using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyClawler.Repository2.Models
{
    public  class interestuser
    {
        public decimal ID { get; set; }
        public string Account { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }
        public sbyte Type { get; set; }
        public bool IsEnable { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}
