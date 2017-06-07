namespace dyClawler.Repository2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.crawlerconfigconfiguration2",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ConfigconfigurationName = c.String(),
                        ConfigconfigurationValue = c.String(),
                        ConfigconfigurationKey = c.Int(nullable: false),
                        DataCreateTime = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ResourceName = c.String(),
                        ResourceLink = c.String(),
                        ResourcePassword = c.String(),
                        ResourceImg = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                        Remark = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        LastUpdateTime = c.DateTime(nullable: false),
                        DownLoadURLList = c.String(),
                        MovieType = c.Int(nullable: false),
                        MovieIntro = c.String(),
                        OnlineUrl = c.String(),
                        SoureceDomain = c.String(),
                        PubDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movie");
            DropTable("dbo.crawlerconfigconfiguration2");
        }
    }
}
