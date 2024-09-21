using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Repositories
{
    public class GameRepository: IGameRepository
    {
        public Dictionary<int, Game> Games = new Dictionary<int, Game>();

        // Get Game by Id
        public Game GetGame(int id)
        {
            return Games[id];
        }

        // Add a Game
        public void AddGame(Game game)
        {
            Games.Add(game.Id, game);
        }
    }
}
