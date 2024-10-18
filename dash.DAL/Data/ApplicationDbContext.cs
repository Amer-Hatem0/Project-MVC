using dash.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dash.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceBin> ServiceBin { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Blog> Blog { get; set; }
    }
}
