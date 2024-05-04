using Microsoft.AspNetCore.Identity;

namespace DeleveryApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }

}
