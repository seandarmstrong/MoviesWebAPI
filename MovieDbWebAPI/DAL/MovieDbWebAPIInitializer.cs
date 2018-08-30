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
                    "The epic fight for freedom as William Wallace defies Scottland's odds and inspires the nation to defeat England.",
                Rating = "R"
            });
            context.Movies.Add(new Movie()
            {
                Id = 2,
                Category = "Drama",
                Title = "Shawshank Redeption",
                Description =
                    "One man's epic crawl through massive amounts of poo for freedom.",
                Rating = "R"
            });
            context.Movies.Add(new Movie()
            {
                Id = 3,
                Category = "Drama",
                Title = "Dangerous Minds",
                Description =
                    "An attractive teacher captivates the hearts and minds of students in an inner-city school through writing.",
                Rating = "PG-13"
            });
            context.Movies.Add(new Movie()
            {
                Id = 4,
                Category = "Animated",
                Title = "Coco",
                Description =
                    "A movie centered around the Day of the Dead that will tug your heartstrings and make you cry.",
                Rating = "G"
            });
            context.Movies.Add(new Movie()
            {
                Id = 5,
                Category = "Animated",
                Title = "Shrek",
                Description =
                    "Who knew a kid's movie could be so funny. An instant classic.",
                Rating = "PG"
            });
            context.Movies.Add(new Movie()
            {
                Id = 6,
                Category = "Horror",
                Title = "IT",
                Description =
                    "A sewer-dwelling clown terrorizes the youth of Castle Rock.",
                Rating = "R"
            });
            context.Movies.Add(new Movie()
            {
                Id = 7,
                Category = "Horror",
                Title = "The Shining",
                Description =
                    "Here's Johnny! This will keep you on the edge of your seat and make you pull your sheets up at night.",
                Rating = "R"
            });
            context.Movies.Add(new Movie()
            {
                Id = 8,
                Category = "Sci-Fi",
                Title = "Star Wars: A New Hope",
                Description =
                    "The ultimate battle between the dark side and the light side.",
                Rating = "PG"
            });
            context.Movies.Add(new Movie()
            {
                Id = 9,
                Category = "Sci-Fi",
                Title = "Cloverfield",
                Description =
                    "Aliens are coming to Earth and this is proof.",
                Rating = "PG-13"
            });
            context.Movies.Add(new Movie()
            {
                Id = 10,
                Category = "Sci-Fi",
                Title = "Aliens",
                Description =
                    "We couldn't wait for aliens on Earth so we sought them out in space.",
                Rating = "R"
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}