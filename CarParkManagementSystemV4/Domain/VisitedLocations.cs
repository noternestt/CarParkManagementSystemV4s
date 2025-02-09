namespace CarParkManagementSystemV4.Domain
{
    public class VisitedLocations
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key for User
        public int LocationId { get; set; } // Foreign Key for Location

        // Navigation properties
        public User User { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
