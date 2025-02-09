using CarParkManagementSystemV4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarParkManagementSystemV4.Configuration.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                 new Model
                 {
                     Id = 1,
                     ModelName = "Toyota Corolla Altis"
                 },
                 new Model
                 {
                     Id = 2,
                     ModelName = "Toyota Prius"
                 },
                 new Model
                 {
                     Id = 3,
                     ModelName = "Honda Vezel"
                 },
                 new Model
                 {
                     Id = 4,
                     ModelName = "Honda Fit"
                 },
                 new Model
                 {
                     Id = 5,
                     ModelName = "BMW 3 Series"
                 },
                 new Model
                 {
                     Id = 6,
                     ModelName = "Mazda 3"
                 },
                 new Model
                 {
                     Id = 7,
                     ModelName = "Volkswagen Golf"
                 },
                 new Model
                 {
                     Id = 8,
                     ModelName = "Honda Civic"
                 }
            );
        }
    }
}
