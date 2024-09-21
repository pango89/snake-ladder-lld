// Models/LadderFactory.cs
using SnakeLadderLLD.Models;

namespace SnakeLadderLLD.Factories
{
    public static class LadderFactory
    {
        public static Ladder CreateLadder(int bottom, int top)
        {
            return new Ladder(bottom, top);
        }
    }
}