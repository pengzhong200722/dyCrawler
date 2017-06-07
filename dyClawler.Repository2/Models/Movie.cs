using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyClawler.Repository2.Models
{
    public  class Movie
    {
        public int ID { get; set; }
        public string ResourceName { get; set; }
        public string ResourceLink { get; set; }
        public string ResourcePassword { get; set; }
        public string ResourceImg { get; set; }
        public bool IsEnable { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string DownLoadURLList { get; set; }
        public int MovieType { get; set; }
        public string MovieIntro { get; set; }
        public string OnlineUrl { get; set; }
        public string SoureceDomain { get; set; }
        public DateTime PubDate { get; set; }
    }
}
