using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Services
{
    public interface IGameService
    {
        Game GetGame(int id);
        void AddGame(Game game);
        Dictionary<int, int> GetPlayerPositions(int gameId);
        int Move(int playerId, int gameId);
    }
}