namespace TryConsole_Wpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        IdClassRoom = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.IdClassRoom);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        IdStudent = c.Int(nullable: false, identity: true),
                        FIO = c.String(maxLength: 50),
                        ClassRoomId = c.Int(),
                        ClassRoom_IdClassRoom = c.Int(),
                    })
                .PrimaryKey(t => t.IdStudent)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoom_IdClassRoom)
                .Index(t => t.ClassRoom_IdClassRoom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassRoom_IdClassRoom", "dbo.ClassRooms");
            DropIndex("dbo.Students", new[] { "ClassRoom_IdClassRoom" });
            DropTable("dbo.Students");
            DropTable("dbo.ClassRooms");
        }
    }
}
