﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace dyClawler.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class luofu_interestshareDbcontext : DbContext
    {
        public luofu_interestshareDbcontext()
            : base("luofu_interestshareDbcontext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    
        public DbSet<crawlerconfigconfiguration> crawlerconfigconfiguration { get; set; }
        public DbSet<resource> resource { get; set; }
        public DbSet<interestuser> interestuser { get; set; }
    }
}