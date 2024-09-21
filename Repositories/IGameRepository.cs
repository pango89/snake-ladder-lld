// Repositories/IGameRepository.cs
using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Repositories
{
    public interface IGameRepository
    {
        // Get Game by Id
        Game GetGame(int id);
        // Add a Game
        void AddGame(Game game);
    }
}