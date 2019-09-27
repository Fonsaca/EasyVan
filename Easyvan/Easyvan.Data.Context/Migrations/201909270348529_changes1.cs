namespace Easyvan.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransportShift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Passenger", "Shift_Id", c => c.Int());
            CreateIndex("dbo.Passenger", "Shift_Id");
            AddForeignKey("dbo.Passenger", "Shift_Id", "dbo.TransportShift", "Id");
            DropColumn("dbo.Passenger", "Shift");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passenger", "Shift", c => c.Int(nullable: false));
            DropForeignKey("dbo.Passenger", "Shift_Id", "dbo.TransportShift");
            DropIndex("dbo.Passenger", new[] { "Shift_Id" });
            DropColumn("dbo.Passenger", "Shift_Id");
            DropTable("dbo.TransportShift");
        }
    }
}
