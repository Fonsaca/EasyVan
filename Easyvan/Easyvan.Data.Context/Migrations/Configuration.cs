namespace Easyvan.Data.Context.Migrations
{
    using Easyvan.Data.Entity.Vehicles;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Easyvan.Data.Context.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Easyvan.Data.Context.Context.DatabaseContext context)
        {
            context.TransportShifts.Add(
                new TransportShift()
                {
                    Id = (int)Core.Domain.Enums.TransportShiftEnum.Afternoon,
                    Value = Enum.GetName(typeof(Core.Domain.Enums.TransportShiftEnum), Core.Domain.Enums.TransportShiftEnum.Afternoon)
                });

            context.TransportShifts.Add(
                new TransportShift()
                {
                    Id = (int)Core.Domain.Enums.TransportShiftEnum.Evening,
                    Value = Enum.GetName(typeof(Core.Domain.Enums.TransportShiftEnum), Core.Domain.Enums.TransportShiftEnum.Evening)
                });

            context.TransportShifts.Add(
                new TransportShift()
                {
                    Id = (int)Core.Domain.Enums.TransportShiftEnum.Morning,
                    Value = Enum.GetName(typeof(Core.Domain.Enums.TransportShiftEnum), Core.Domain.Enums.TransportShiftEnum.Morning)
                });
        }
    }
}
