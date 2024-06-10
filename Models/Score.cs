using System;

namespace LeaderboardAPI.Models
{
    public class Score
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int Points { get; set; }
        public DateTime Date { get; set; }
    }
}
