using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyClawler.Repository2.Models
{
    public class crawlerconfigconfiguration2
    {
        public int ID { get; set; }
        public string ConfigconfigurationName { get; set; }
        public string ConfigconfigurationValue { get; set; }
        public int ConfigconfigurationKey { get; set; }
        public DateTime DataCreateTime { get; set; }
        public bool IsEnabled { get; set; }
    }
}
