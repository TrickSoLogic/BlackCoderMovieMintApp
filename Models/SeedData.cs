using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCoderMovieMintApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Title1",
                        ReleaseDate = DateTime.Parse("2015-03-06"),
                        Genre = "Romantic Comedy",
                        Rating = 7
                    },
                    new Movie
                    {
                        Title = "Title2",
                        ReleaseDate = DateTime.Parse("2006-09-04"),
                        Genre = "Comedy",
                        Rating = 10
                    },
                    new Movie
                    {
                        Title = "Title3",
                        ReleaseDate = DateTime.Parse("2008-05-12"),
                        Genre = " Comedy",
                        Rating = 12
                    },
                    new Movie
                    {
                        Title = "Title4",
                        ReleaseDate = DateTime.Parse("2003-08-02"),
                        Genre = "Western",
                        Rating = 6
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
