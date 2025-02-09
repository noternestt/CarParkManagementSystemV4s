using CarParkManagementSystemV4.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarParkManagementSystemV4.Configuration.Entities
{
    public class VehicleTypeSeed : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VehicleType> builder)
        {
            builder.HasData(
               new VehicleType
               {
                   Id = 1,
                   TypeName = "Sedan",
                   Description = "Compact or mid-sized cars"
               },
               new VehicleType
               {
                   Id = 2,
                   TypeName = "SUV",
                   Description = "Sport Utility Vehicle"
               },
               new VehicleType
               {
                   Id = 3,
                   TypeName = "Hatchback",
                   Description = "Compact cars with a rear door"
               },
               new VehicleType
               {
                   Id = 4,
                   TypeName = "Convertible",
                   Description = "Cars with a retractable roof"
               },
               new VehicleType
               {
                   Id = 5,
                   TypeName = "Van",
                   Description = "Large passenger or cargo vehicles"
               },
               new VehicleType
               {
                   Id = 6,
                   TypeName = "Motorcycle",
                   Description = "Two-wheeled motorized vehicles"
               }
            );

        }
    }
}
