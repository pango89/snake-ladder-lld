// Models/SnakeFactory.cs
using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Factories
{
    public static class SnakeFactory
    {
        public static Snake CreateSnake(int head, int tail)
        {
            return new Snake(head, tail);
        }
    }
}