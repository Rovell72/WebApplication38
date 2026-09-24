using Microsoft.AspNetCore.Identity;

namespace WebApplication38.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
