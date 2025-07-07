using Microsoft.AspNetCore.Identity;

namespace CustomUserRoll.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
