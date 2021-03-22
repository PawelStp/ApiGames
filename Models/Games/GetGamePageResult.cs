using System.Collections.Generic;
using System.Linq;

namespace Games.Api.Models.Games
{
    public class GetGamePageResult : PageBaseResult<Game>
    {
        public GetGamePageResult(IList<Core.Entities.Games.Game> games)
        {
            Data = games.Select(x => new Game
            {
                Title = x.Title,
                Description = x.Description,
                ReleaseDate = x.ReleaseDate,
                Url = x.Url
            }).ToList();
            Count = 100;
            PageIndex = 1;
        }
    }
}
