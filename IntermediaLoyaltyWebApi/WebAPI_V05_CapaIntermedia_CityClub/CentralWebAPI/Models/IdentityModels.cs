using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace WebApplication4.Models
{
    
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        //public string Name { get; set; }

        //public string Email { get; set; }
    }

    //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
    //{
    //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
    //    var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
    //    // Add custom user claims here
    //    return userIdentity;
    //}
    //}

    public class ApplicationDbContext 
    {
        public ApplicationDbContext()
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}