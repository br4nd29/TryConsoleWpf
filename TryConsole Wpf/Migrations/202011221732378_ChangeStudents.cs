namespace TryConsole_Wpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudents : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "ClassRoomId");
            RenameColumn(table: "dbo.Students", name: "ClassRoom_IdClassRoom", newName: "ClassRoomId");
            RenameIndex(table: "dbo.Students", name: "IX_ClassRoom_IdClassRoom", newName: "IX_ClassRoomId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_ClassRoomId", newName: "IX_ClassRoom_IdClassRoom");
            RenameColumn(table: "dbo.Students", name: "ClassRoomId", newName: "ClassRoom_IdClassRoom");
            AddColumn("dbo.Students", "ClassRoomId", c => c.Int());
        }
    }
}
