namespace Easyvan.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.String(unicode: false),
                        City = c.String(unicode: false),
                        Neighborhood = c.String(unicode: false),
                        Street = c.String(unicode: false),
                        Number = c.Int(nullable: false),
                        Additional = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CancelTravel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Passenger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passenger", t => t.Passenger_Id)
                .Index(t => t.Passenger_Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(unicode: false),
                        RG = c.String(unicode: false),
                        CPF = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Active = c.Boolean(),
                        Created = c.DateTime(nullable: false, precision: 0),
                        Deleted = c.DateTime(nullable: false, precision: 0),
                        Address_Id = c.Int(),
                        Notification_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Notification", t => t.Notification_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Notification_Id);
            
            CreateTable(
                "dbo.Institution",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Active = c.Boolean(),
                        Created = c.DateTime(nullable: false, precision: 0),
                        Deleted = c.DateTime(nullable: false, precision: 0),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.InstitutionPhoneNumber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(unicode: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institution", t => t.Contact_Id)
                .Index(t => t.Contact_Id);
            
            CreateTable(
                "dbo.Notification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(unicode: false),
                        Body = c.String(unicode: false),
                        SendTime = c.DateTime(nullable: false, precision: 0),
                        Person_Id = c.Int(),
                        Sender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Person_Id)
                .ForeignKey("dbo.Person", t => t.Sender_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Sender_Id);
            
            CreateTable(
                "dbo.PersonPhoneNumber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(unicode: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Contact_Id)
                .Index(t => t.Contact_Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Plate = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Brand = c.String(unicode: false),
                        Model = c.String(unicode: false),
                        Number = c.String(unicode: false),
                        Seats = c.Short(nullable: false),
                        Active = c.Boolean(),
                        Created = c.DateTime(nullable: false, precision: 0),
                        Deleted = c.DateTime(nullable: false, precision: 0),
                        Driver_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Plate)
                .ForeignKey("dbo.Driver", t => t.Driver_Id)
                .ForeignKey("dbo.Owner", t => t.Owner_Id)
                .Index(t => t.Driver_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDay = c.Short(nullable: false),
                        Value = c.Double(nullable: false),
                        Template = c.String(unicode: false),
                        ContractValue = c.String(unicode: false),
                        Active = c.Boolean(),
                        Created = c.DateTime(nullable: false, precision: 0),
                        Deleted = c.DateTime(nullable: false, precision: 0),
                        Passenger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passenger", t => t.Passenger_Id)
                .Index(t => t.Passenger_Id);
            
            CreateTable(
                "dbo.Rate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Satisfaction = c.Short(nullable: false),
                        Comment = c.String(unicode: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Active = c.Boolean(),
                        Created = c.DateTime(nullable: false, precision: 0),
                        Deleted = c.DateTime(nullable: false, precision: 0),
                        RatedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.RatedBy_Id)
                .Index(t => t.RatedBy_Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.DriverRate",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Driver_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rate", t => t.Id)
                .ForeignKey("dbo.Driver", t => t.Driver_Id)
                .Index(t => t.Id)
                .Index(t => t.Driver_Id);
            
            CreateTable(
                "dbo.Driver",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Hirer_Id = c.Int(),
                        CNH = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .ForeignKey("dbo.Owner", t => t.Hirer_Id)
                .Index(t => t.Id)
                .Index(t => t.Hirer_Id);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CNPJ = c.String(unicode: false),
                        TransportLicense = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DeliverAddress_Id = c.Int(),
                        Institution_Id = c.Int(),
                        Responsable_Id = c.Int(),
                        Vehicle_Plate = c.String(maxLength: 128, storeType: "nvarchar"),
                        PickupAddress_Id = c.Int(),
                        StartShiftTime = c.Time(nullable: false, precision: 0),
                        FinishShiftTime = c.Time(nullable: false, precision: 0),
                        Shift = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .ForeignKey("dbo.Address", t => t.DeliverAddress_Id)
                .ForeignKey("dbo.Institution", t => t.Institution_Id)
                .ForeignKey("dbo.Client", t => t.Responsable_Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Plate)
                .ForeignKey("dbo.Address", t => t.PickupAddress_Id)
                .Index(t => t.Id)
                .Index(t => t.DeliverAddress_Id)
                .Index(t => t.Institution_Id)
                .Index(t => t.Responsable_Id)
                .Index(t => t.Vehicle_Plate)
                .Index(t => t.PickupAddress_Id);
            
            CreateTable(
                "dbo.TransportRate",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TranportOwner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rate", t => t.Id)
                .ForeignKey("dbo.Owner", t => t.TranportOwner_Id)
                .Index(t => t.Id)
                .Index(t => t.TranportOwner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransportRate", "TranportOwner_Id", "dbo.Owner");
            DropForeignKey("dbo.TransportRate", "Id", "dbo.Rate");
            DropForeignKey("dbo.Passenger", "PickupAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Passenger", "Vehicle_Plate", "dbo.Vehicle");
            DropForeignKey("dbo.Passenger", "Responsable_Id", "dbo.Client");
            DropForeignKey("dbo.Passenger", "Institution_Id", "dbo.Institution");
            DropForeignKey("dbo.Passenger", "DeliverAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Passenger", "Id", "dbo.Person");
            DropForeignKey("dbo.Owner", "Id", "dbo.Person");
            DropForeignKey("dbo.Driver", "Hirer_Id", "dbo.Owner");
            DropForeignKey("dbo.Driver", "Id", "dbo.Person");
            DropForeignKey("dbo.DriverRate", "Driver_Id", "dbo.Driver");
            DropForeignKey("dbo.DriverRate", "Id", "dbo.Rate");
            DropForeignKey("dbo.Client", "Id", "dbo.Person");
            DropForeignKey("dbo.Rate", "RatedBy_Id", "dbo.Client");
            DropForeignKey("dbo.Contract", "Passenger_Id", "dbo.Passenger");
            DropForeignKey("dbo.CancelTravel", "Passenger_Id", "dbo.Passenger");
            DropForeignKey("dbo.Notification", "Sender_Id", "dbo.Person");
            DropForeignKey("dbo.Person", "Notification_Id", "dbo.Notification");
            DropForeignKey("dbo.Vehicle", "Owner_Id", "dbo.Owner");
            DropForeignKey("dbo.Vehicle", "Driver_Id", "dbo.Driver");
            DropForeignKey("dbo.PersonPhoneNumber", "Contact_Id", "dbo.Person");
            DropForeignKey("dbo.Notification", "Person_Id", "dbo.Person");
            DropForeignKey("dbo.Person", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.InstitutionPhoneNumber", "Contact_Id", "dbo.Institution");
            DropForeignKey("dbo.Institution", "Address_Id", "dbo.Address");
            DropIndex("dbo.TransportRate", new[] { "TranportOwner_Id" });
            DropIndex("dbo.TransportRate", new[] { "Id" });
            DropIndex("dbo.Passenger", new[] { "PickupAddress_Id" });
            DropIndex("dbo.Passenger", new[] { "Vehicle_Plate" });
            DropIndex("dbo.Passenger", new[] { "Responsable_Id" });
            DropIndex("dbo.Passenger", new[] { "Institution_Id" });
            DropIndex("dbo.Passenger", new[] { "DeliverAddress_Id" });
            DropIndex("dbo.Passenger", new[] { "Id" });
            DropIndex("dbo.Owner", new[] { "Id" });
            DropIndex("dbo.Driver", new[] { "Hirer_Id" });
            DropIndex("dbo.Driver", new[] { "Id" });
            DropIndex("dbo.DriverRate", new[] { "Driver_Id" });
            DropIndex("dbo.DriverRate", new[] { "Id" });
            DropIndex("dbo.Client", new[] { "Id" });
            DropIndex("dbo.Rate", new[] { "RatedBy_Id" });
            DropIndex("dbo.Contract", new[] { "Passenger_Id" });
            DropIndex("dbo.Vehicle", new[] { "Owner_Id" });
            DropIndex("dbo.Vehicle", new[] { "Driver_Id" });
            DropIndex("dbo.PersonPhoneNumber", new[] { "Contact_Id" });
            DropIndex("dbo.Notification", new[] { "Sender_Id" });
            DropIndex("dbo.Notification", new[] { "Person_Id" });
            DropIndex("dbo.InstitutionPhoneNumber", new[] { "Contact_Id" });
            DropIndex("dbo.Institution", new[] { "Address_Id" });
            DropIndex("dbo.Person", new[] { "Notification_Id" });
            DropIndex("dbo.Person", new[] { "Address_Id" });
            DropIndex("dbo.CancelTravel", new[] { "Passenger_Id" });
            DropTable("dbo.TransportRate");
            DropTable("dbo.Passenger");
            DropTable("dbo.Owner");
            DropTable("dbo.Driver");
            DropTable("dbo.DriverRate");
            DropTable("dbo.Client");
            DropTable("dbo.Rate");
            DropTable("dbo.Contract");
            DropTable("dbo.Vehicle");
            DropTable("dbo.PersonPhoneNumber");
            DropTable("dbo.Notification");
            DropTable("dbo.InstitutionPhoneNumber");
            DropTable("dbo.Institution");
            DropTable("dbo.Person");
            DropTable("dbo.CancelTravel");
            DropTable("dbo.Address");
        }
    }
}
