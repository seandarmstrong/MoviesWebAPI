using MovieDbWebAPI.Models;
using System.Data.Entity;

namespace MovieDbWebAPI.DAL
{
    class MovieDbWebAPIInitializer : CreateDatabaseIfNotExists<MovieDbContext>
    {
        protected override void Seed(MovieDbContext context)
        {
            context.Movies.Add(new Movie()
            {
                Id = 1,
                Category = "Drama",
                Title = "Braveheart",
                Description =
                    "The epic fight for freedom as William Wallace defies Scottland's odds and inspires the nation to defeat England"
            });
            context.Movies.Add(new Movie()
            {
                Id = 2,
                Category = "Drama",
                Title = "Braveheart",
                Description =
                    "The epic fight for freedom as William Wallace defies Scottland's odds and inspires the nation to defeat England"
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}