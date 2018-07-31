using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutomotiveForum.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string UserRole { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Adress")]
        public string StreetAdress { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<AutomotiveForum.Models.Forum> Fora { get; set; }

        public System.Data.Entity.DbSet<AutomotiveForum.Models.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<AutomotiveForum.Models.Comments> Comments { get; set; }

        //public System.Data.Entity.DbSet<AutomotiveForum.Models.ApplicationUser> ApplicationUsers { get; set; }

        //remember to reset applicationUser to "User" asp doesn't recognize ApplicationUser as a correct path to table.

        // public System.Data.Entity.DbSet<AutomotiveForum.Models.ApplicationUser> ApplicationUsers { get; set; }       
    }
}