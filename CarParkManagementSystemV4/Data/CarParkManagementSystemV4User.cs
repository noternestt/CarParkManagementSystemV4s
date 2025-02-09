using Microsoft.AspNetCore.Identity;

namespace CarParkManagementSystemV4.Data
{
    public class CarParkManagementSystemV4User:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
