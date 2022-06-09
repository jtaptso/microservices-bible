using BibleAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BibleAPI.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Bible> Bibles { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Testament> Testaments { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Chapitre> Chapitres { get; set; }
        public DbSet<Verset> Versets { get; set; }
        public DbSet<VersetVersion> Versions { get; set; }
    }
}
