using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WatchList.Models;

namespace WatchList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmUser> FilmUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FilmUser>()
            .HasKey(t => new { t.IdUser, t.IdFilm });
        }
        public DbSet<WatchList.Models.ModelViewFilm> ModelViewFilm { get; set; } = default!;
    }
}
