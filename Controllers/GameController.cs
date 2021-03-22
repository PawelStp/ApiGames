using Games.Api.Models.Games;
using Games.Core.Interfaces.Repositories;
using Games.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Games.Api.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;
        private readonly IGameRepository _gameRepository;

        public GameController(GameService gameService, IGameRepository gameRepository)
        {
            _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
            _gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
        }


        [HttpGet]
        public async Task<ActionResult<GetGamePageResult>> GetGamePage(CancellationToken cancellationToken)
        {
            var games = await _gameRepository.GetAll(cancellationToken);

            return Ok(new GetGamePageResult(games));
        }


        [HttpPost]
        public async Task<ActionResult<GetGamePageResult>> GetGamePage(CreateGameParameters createGameParameters, CancellationToken cancellationToken)
        {
            await _gameService.Create(createGameParameters.ToDomainParameters(), cancellationToken);
            return Ok();
        }
    }
}
