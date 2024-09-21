using SnakeLadderLLD.Models;
using SnakeLadderLLD.Services;

namespace SnakeLadderLLD.Controllers
{
    public class GameController
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // Get Game by Id
        public Game GetGame(int id)
        {
            return _gameService.GetGame(id);
        }

        // Add a Game
        public void AddGame(Game game)
        {
            _gameService.AddGame(game);
        }

        // function to get player positions in Game Board
        public void DisplayPlayerPositions(int gameId, int playerId)
        {
            Dictionary<int, int> playerPositionMap = _gameService.GetPlayerPositions(gameId);
            var position = playerPositionMap[playerId];
            Console.WriteLine($"{playerId} is at position {position}");
        }

        // function to Move one player
        public int Move(int playerId, int gameId)
        {
            return _gameService.Move(playerId, gameId);
        }
    }
}