using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementWithIdentity.Models;

namespace UserManagementWithIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.HasDefaultSchema("IDI");
            //ignore EmailConfirmed from the Users table
            //builder.Entity<IdentityUser>().Ignore(u => u.EmailConfirmed);
            builder.Entity<ApplicationUser>().ToTable("Users", "Security"); // renaming the table and renaming it's SCHEMA
            builder.Entity<IdentityRole>().ToTable("Roles", "Security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");






        }
        public DbSet<MyTask> myTasks { get; set; }



    }
}