namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangID = c.String(nullable: false, maxLength: 128, unicode: false),
                        KhachHangName = c.String(),
                        KhachHangDiaChi = c.String(),
                        KhachHangSodt = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
            AlterColumn("dbo.Accounts", "Password", c => c.String(unicode: false));
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.Int(nullable: false),
                        Address = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            AlterColumn("dbo.Accounts", "Password", c => c.String());
            DropTable("dbo.KhachHangs");
        }
    }
}
