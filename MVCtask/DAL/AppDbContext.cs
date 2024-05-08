using Microsoft.EntityFrameworkCore;
using MVCtask.Models;

namespace MVCtask.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrganicProduct> OrganicProducts { get; set; }
       
        public DbSet<Farmer> Farmers { get; set; }
    }
}
