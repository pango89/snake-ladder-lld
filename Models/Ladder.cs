namespace SnakeLadderLLD.Models
{
    public class Ladder
    {
        public Ladder(int bottom, int top)
        {
            Bottom = bottom;
            Top = top;
        }

        public int Bottom { get; private set; }
        public int Top { get; private set; }
    }
}
