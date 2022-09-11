using Microsoft.AspNetCore.Identity;

namespace HotelVillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
