using Microsoft.EntityFrameworkCore;
using GameApp.Data;

namespace GameApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GameAppContext>>()))
            {
                // Look for any games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }


                context.Game.AddRange(
                    new Game
                    {
                        Name = "Snooker 19",
                        ReleaseDate = DateTime.Parse("2022-2-1"),
                        Genre = "2D Plaformer",
                        Price = 21.99M,

                    },

                    new Game
                    {
                        Name = "The LEGO Movie",
                        ReleaseDate = DateTime.Parse("2020-6-9"),
                        Genre = "RPG",
                        Price = 18.99M
                    },

                    new Game
                    {
                        Name = "JUMANJI",
                        ReleaseDate = DateTime.Parse("2021-10-22"),
                        Genre = "Action",
                        Price = 30.99M
                    },

                    new Game
                    {
                        Name = "FIFA 22 ",
                        ReleaseDate = DateTime.Parse("2021-10-1"),
                        Genre = "Sports",
                        Price = 5.99M
                    },
                     new Game
                     {
                         Name = "Diablo Iv ",
                         ReleaseDate = DateTime.Parse("2023-6-6"),
                         Genre = "RPG",
                         Price = 99.99M
                     },
                      new Game
                      {
                          Name = "Jurassic World Evolution 2 ",
                          ReleaseDate = DateTime.Parse("2021-11-9"),
                          Genre = "Strategy",
                          Price = 7.99M
                      },
                       new Game
                       {
                           Name = "Middle Earth Shadow Of War",
                           ReleaseDate = DateTime.Parse("2019-4-15"),
                           Genre = "RPG",
                           Price = 4.99M
                       },
                        new Game
                        {
                            Name = "Fallout 4",
                            ReleaseDate = DateTime.Parse("2020-4-13"),
                            Genre = "Action RPG",
                            Price = 3.99M
                        }
                 );
                context.Review.Add(new Review { GameId = 1, PublishDate = DateTime.Now, ReviewMessage = "Mi-a placut!", User = "Tania" });

                context.SaveChanges();
            }
        }
    }
}