using SnakeLadderLLD.Models;
using SnakeLadderLLD.Repositories;

namespace SnakeLadderLLD.Services
{
    public class GameService: IGameService
    {
        private readonly IGameRepository _gameRepository;

        // constructor
        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // Get Game by Id
        public Game GetGame(int id)
        {
            return _gameRepository.GetGame(id);
        }   

        // Add a Game
        public void AddGame(Game game)
        {
            _gameRepository.AddGame(game);
        }

        // function to get player positions in Game Board
        public Dictionary<int, int> GetPlayerPositions(int gameId)
        {
            Game game = _gameRepository.GetGame(gameId);
            return game.PlayersPositionMap;
        }

        // function to Move one player
        public int Move(int playerId, int gameId)
        {
            Game game = _gameRepository.GetGame(gameId);
            return game.Move(playerId);
        }
    }
}