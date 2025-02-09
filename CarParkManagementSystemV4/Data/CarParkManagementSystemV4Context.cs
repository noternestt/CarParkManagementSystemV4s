using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CarParkManagementSystemV4.Configuration.Entities;
using CarParkManagementSystemV4.Configurations.Entities;
using CarRentalManagement.Configurations.Entities;
using CarParkManagementSystemV4.Domain;

namespace CarParkManagementSystemV4.Data
{
    public class CarParkManagementSystemV4Context: IdentityDbContext<CarParkManagementSystemV4User>
    {
        public CarParkManagementSystemV4Context(DbContextOptions<CarParkManagementSystemV4Context> options)
            : base(options)
        {
        }
        public DbSet<CarParkManagementSystemV4.Domain.User> User { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.Location> Location { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.VehicleType> VehicleType { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.Model> Model { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.Vehicle> Vehicle { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.ParkingSession> ParkingSession { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.PaymentMethod> PaymentMethod { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.Pricing> Pricing { get; set; } = default!;
            public DbSet<CarParkManagementSystemV4.Domain.VisitedLocations> VisitedLocation { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                builder.ApplyConfiguration(new LocationSeed());
                builder.ApplyConfiguration(new VehicleTypeSeed());
                builder.ApplyConfiguration(new RoleSeed());
                builder.ApplyConfiguration(new UserRoleSeed());
                builder.ApplyConfiguration(new UserSeed());
                builder.ApplyConfiguration(new ModelSeed());
            builder.Entity<User>()
            .HasMany(u => u.PaymentMethods)
            .WithOne(p => p.User)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.Vehicles)
                .WithOne(v => v.User)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<VisitedLocations>()
                .HasOne(vl => vl.User)
                .WithMany()
                .HasForeignKey(vl => vl.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<VisitedLocations>()
                .HasOne(vl => vl.Location)
                .WithMany()
                .HasForeignKey(vl => vl.LocationId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
    }
