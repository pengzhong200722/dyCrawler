using dyClawler.Repository2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyClawler.Repository2
{
    public class luofu_interestshareDbcontext : DbContext
    {
        public luofu_interestshareDbcontext()
        {

        }

        public luofu_interestshareDbcontext(string luofu_interestshareDbcontext)
            : base(luofu_interestshareDbcontext)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<crawlerconfigconfiguration2> crawlerconfigconfiguration { get; set; }
        public DbSet<Movie> resource { get; set; }
    }
}
