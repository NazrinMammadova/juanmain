using Microsoft.AspNetCore.Identity;

namespace JuanMain.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }

    }

}
