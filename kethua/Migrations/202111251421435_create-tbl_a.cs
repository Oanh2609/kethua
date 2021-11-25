namespace kethua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtbl_a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        makhoa = c.String(nullable: false, maxLength: 128),
                        tenkhoa = c.String(),
                    })
                .PrimaryKey(t => t.makhoa);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        malop = c.String(nullable: false, maxLength: 128),
                        tenlop = c.String(),
                        makhoa = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.malop)
                .ForeignKey("dbo.Khoas", t => t.makhoa)
                .Index(t => t.makhoa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lops", "makhoa", "dbo.Khoas");
            DropIndex("dbo.Lops", new[] { "makhoa" });
            DropTable("dbo.Lops");
            DropTable("dbo.Khoas");
        }
    }
}
