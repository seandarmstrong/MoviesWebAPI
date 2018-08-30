using MovieDbWebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Diagnostics;

namespace MovieDbWebAPI.DAL
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("MovieDbWebAPI")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MovieDbWebAPIInitializer());
            Database.Log = message => Trace.WriteLine(message);
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(x => x.Id).Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}