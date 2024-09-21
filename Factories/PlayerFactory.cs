// Models/PlayerFactory.cs
using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Factories
{
    public static class PlayerFactory
    {
        public static Player CreatePlayer(int id, string name)
        {
            return new Player(id, name);
        }
    }
}