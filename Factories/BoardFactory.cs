// Factories/BoardFactory.cs
using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Factories
{
    public static class BoardFactory
    {
        public static Board CreateBoard(int size, Snake[] snakes, Ladder[] ladders)
        {
            return new Board(size, snakes, ladders);
        }
    }
}