using dash.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dash.DAL.Data
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
            var roleAdminId = Guid.NewGuid().ToString();
            var roleSuperAdminId = Guid.NewGuid().ToString();
            var roleUserId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = roleAdminId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = roleSuperAdminId, Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                new IdentityRole { Id = roleUserId, Name = "User", NormalizedName = "USER" }
            );

            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user@cmp.com",
                NormalizedUserName = "USER@CMP.COM",
                Email = "user@cmp.com",
                NormalizedEmail = "USER@CMP.COM",
                EmailConfirmed = true,
            };
            user.PasswordHash = hasher.HashPassword(user, "User@12");
            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "adminUser@comp.com",
                NormalizedUserName = "ADMINUSER@COMP.COM",
                Email = "adminUser@comp.com",
                NormalizedEmail = "ADMINUSER@COMP.COM",
                EmailConfirmed = true,
            };
            user.PasswordHash = hasher.HashPassword(adminUser, "User@12");
            var superAdmin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "superAdmin@cmp.com",
                NormalizedUserName = "SUPERADMIN@CMP.COM",
                Email = "superAdmin@cmp.com",
                NormalizedEmail = "SUPERADMIN@CMP.COM",
                EmailConfirmed = true,
            };
            user.PasswordHash = hasher.HashPassword(superAdmin, "User@12");

            builder.Entity<ApplicationUser>().HasData(adminUser, user, superAdmin);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = roleUserId, UserId = user.Id },
                new IdentityUserRole<string> { RoleId = roleAdminId, UserId = adminUser.Id },
                new IdentityUserRole<string> { RoleId = roleSuperAdminId, UserId = superAdmin.Id }
            );
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceBin> ServiceBin { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Blog> Blog { get; set; }
    }
}
