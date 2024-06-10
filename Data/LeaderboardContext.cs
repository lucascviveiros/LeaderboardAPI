using Microsoft.EntityFrameworkCore;
using LeaderboardAPI.Models;

namespace LeaderboardAPI.Data
{
    public class LeaderboardContext : DbContext
    {
        public LeaderboardContext(DbContextOptions<LeaderboardContext> options)
            : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; }
    }
}
