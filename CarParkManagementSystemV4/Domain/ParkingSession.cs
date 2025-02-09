namespace CarParkManagementSystemV4.Domain
{
    public class ParkingSession:BaseDomainModel
    {
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string? Status { get; set; } = "Pending";
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public int VehicleId { get; set; }
        public User User { get; set; } = null!;
    }
}
