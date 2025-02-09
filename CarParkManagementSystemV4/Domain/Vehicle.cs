namespace CarParkManagementSystemV4.Domain
{
    public class Vehicle:BaseDomainModel
    {
        public string? LicensePlate { get; set; }
        public string? Color { get; set; }
        public int UserID { get; set; }
        public int VehicleTypeId { get; set; }
        public int ModelId { get; set; }
        public User User { get; set; } = null!; // Navigation property for User
        public Model Model { get; set; } = null!; // Navigation property for Model
        public VehicleType VehicleType { get; set; }=null!;
    }
}
