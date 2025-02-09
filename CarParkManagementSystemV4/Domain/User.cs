namespace CarParkManagementSystemV4.Domain
{
    public class User : BaseDomainModel
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; } = new();
        public List<Vehicle> Vehicles { get; set; } = new();
        public string IdentityUserId { get; set; } = string.Empty;  // used to store AspNetUser.Id (GUID)
    }

}
