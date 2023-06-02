using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int AddressId { get; set; }
        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();


    }
}
