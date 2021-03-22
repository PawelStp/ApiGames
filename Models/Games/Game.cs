using System;

namespace Games.Api.Models.Games
{
    public class Game
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string Url { get; set; }
        public decimal AverageRate { get; set; }
    }
}
