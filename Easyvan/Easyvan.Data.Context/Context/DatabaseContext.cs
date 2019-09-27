using Easyvan.Data.Context.Map.Bussiness;
using Easyvan.Data.Context.Map.Contact;
using Easyvan.Data.Context.Map.Message;
using Easyvan.Data.Context.Map.People;
using Easyvan.Data.Context.Map.Place;
using Easyvan.Data.Context.Map.Rating;
using Easyvan.Data.Context.Map.Traveling;
using Easyvan.Data.Context.Map.Vehicles;
using Easyvan.Data.Entity.Bussiness;
using Easyvan.Data.Entity.Contact;
using Easyvan.Data.Entity.Message;
using Easyvan.Data.Entity.People;
using Easyvan.Data.Entity.Place;
using Easyvan.Data.Entity.Rating;
using Easyvan.Data.Entity.Traveling;
using Easyvan.Data.Entity.Vehicles;
using MySql.Data.Entity;
using System.Data.Entity;

namespace Easyvan.Data.Context.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("EasyVanConn")
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<InstitutionPhoneNumber> InstitutionPhoneNumbers { get; set; }
        public DbSet<PersonPhoneNumber> PersonPhoneNumbers { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        public DbSet<Rate> Rates { get; set; }
        public DbSet<TransportRate> TransportRates { get; set; }
        public DbSet<DriverRate> DriverRates { get; set; }

        public DbSet<CancelTravel> CancelTravels { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TransportShift> TransportShifts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<Contract>(new ContractMap());
            modelBuilder.Configurations.Add<Person>(new PersonMap());
            modelBuilder.Configurations.Add<Client>(new ClientMap());
            modelBuilder.Configurations.Add<Driver>(new DriverMap());
            modelBuilder.Configurations.Add<Owner>(new OwnerMap());
            modelBuilder.Configurations.Add<Passenger>(new PassengerMap());
            modelBuilder.Configurations.Add<InstitutionPhoneNumber>(new InstitutionPhoneNumberMap());
            modelBuilder.Configurations.Add<PersonPhoneNumber>(new PersonPhoneNumberMap());
            modelBuilder.Configurations.Add<Notification>(new NotificationMap());
            modelBuilder.Configurations.Add<Address>(new AddressMap());
            modelBuilder.Configurations.Add<Institution>(new InstitutionMap());

            modelBuilder.Configurations.Add<Rate>(new RateMap());
            modelBuilder.Configurations.Add<TransportRate>(new TransportRateMap());
            modelBuilder.Configurations.Add<DriverRate>(new DriverRateMap());
            modelBuilder.Configurations.Add<CancelTravel>(new CancelTravelMap());
            modelBuilder.Configurations.Add<Vehicle>(new VehicleMap());
            modelBuilder.Configurations.Add<TransportShift>(new TransportShiftMap());

        }
    }
}
