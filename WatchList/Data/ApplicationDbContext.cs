using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WatchList.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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

            // Specify composite primary key
            modelBuilder.Entity<FilmUser>()
                .HasKey(fu => new { fu.IdUser, fu.IdFilm });
        }

        public DbSet<WatchList.Models.ModelViewFilm> ModelViewFilm { get; set; } = default!;
    }
}
