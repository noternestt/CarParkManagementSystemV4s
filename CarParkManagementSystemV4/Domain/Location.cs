namespace CarParkManagementSystemV4.Domain
{
    public class Location:BaseDomainModel
    {
        public string? Address { get; set; }
        public int PostalCode { get; set; }
        public int TotalSlots { get; set; } // New Property for Total Parking Slots
    }
}
