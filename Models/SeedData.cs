using LeaderboardAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LeaderboardAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LeaderboardContext(
                serviceProvider.GetRequiredService<DbContextOptions<LeaderboardContext>>()))
            {
                // Look for any scores.
                if (context.Scores.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scores.AddRange(
                    new Score
                    {
                        PlayerName = "Player1",
                        Points = 100,
                        Date = DateTime.Now
                    },
                    new Score
                    {
                        PlayerName = "Player2",
                        Points = 200,
                        Date = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
