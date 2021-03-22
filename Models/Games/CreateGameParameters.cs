using Games.Core.Services.Games;
using System;
using System.ComponentModel.DataAnnotations;

namespace Games.Api.Models.Games
{
    public class CreateGameParameters
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTimeOffset ReleaseDate { get; set; }

        [Required]
        public string Url { get; set; }

        internal CreateGameParameters2 ToDomainParameters()
        {
            return new CreateGameParameters2(Title, Description, ReleaseDate, Url);
        }
    }
}
