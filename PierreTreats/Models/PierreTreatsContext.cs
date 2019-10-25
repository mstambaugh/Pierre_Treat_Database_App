using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PierreTreats.Models
{
    public class PierreTreatsContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Treat> Treats { get; set; }
        public DbSet<Flavor> Flavors { get; set; }

        public DbSet<FlavorTreat> FlavorTreat { get; set; }

        public PierreTreatsContext(DbContextOptions options) : base(options) { }
    }
}