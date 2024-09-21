namespace SnakeLadderLLD.Models
{
    public class Snake
    {
        public Snake(int head, int tail)
        {
            Head = head;
            Tail = tail;
        }

        public int Head { get; private set; }
        public int Tail { get; private set; }
    }
}
