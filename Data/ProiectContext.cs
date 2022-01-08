using Microsoft.EntityFrameworkCore;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext(DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Product> Product { get; set; }

        public DbSet<Proiect.Models.Courier> Courier { get; set; }

        public DbSet<Proiect.Models.Category> Category { get; set; }
    }
}
