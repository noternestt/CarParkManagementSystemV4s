namespace CarParkManagementSystemV4.Domain
{
    public class PaymentMethod:BaseDomainModel
    {
        public int CardNumber { get; set; }
        public string? CardHolderName { get; set; }
        public string? ExpiryDate { get; set; }
        public string? CVV { get; set; }
        public string? PaymentType { get; set; }
        public string? Provider { get; set; }
        public int ParkingSessionId { get; set; }
        public int UserId { get; set; }  // Foreign key
        public User User { get; set; } = null!;

    }
}
