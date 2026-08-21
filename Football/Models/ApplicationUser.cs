using Microsoft.AspNetCore.Identity;
namespace Football.Models
{
  
        public class ApplicationUser : IdentityUser
        {
            public string City { get; set; }
        }
    }

