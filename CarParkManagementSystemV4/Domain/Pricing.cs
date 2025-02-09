namespace CarParkManagementSystemV4.Domain
{
    public class Pricing:BaseDomainModel
    {
        public double HourlyRate { get; set; }
        public double WeekendRate { get; set; }
        public int LocationId { get; set; }
        // Navigation property
        public Location Location { get; set; } = null!;
    }
}
