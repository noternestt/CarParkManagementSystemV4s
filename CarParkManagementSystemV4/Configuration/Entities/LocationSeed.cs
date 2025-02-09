using CarParkManagementSystemV4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarParkManagementSystemV4.Configuration.Entities
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                 new Location
                 {
                     Id = 1,
                     Address = "971A Hougang Street 91",
                     PostalCode = 531971
                 },
                 new Location
                 {
                     Id = 2,
                     Address = "988 Buangkok Green",
                     PostalCode = 530988
                 },
                 new Location
                 {
                     Id= 3,
                     Address = "54 Serangoon North Ave 4",
                     PostalCode = 555854
                 },
                 new Location
                 {
                     Id= 4,
                     Address = "23 Serangoon Central",
                     PostalCode = 556083
                 },
                 new Location
                 {
                     Id= 5,
                     Address = "823A Tampines Street 81",
                     PostalCode = 521823

                 },
                 new Location
                 {
                     Id = 6,
                     Address = "879C Tampines Ave 8",
                     PostalCode = 523879
                 }
             );

        }
    }
}
