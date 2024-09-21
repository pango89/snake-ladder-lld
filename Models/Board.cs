namespace SnakeLadderLLD.Models
{
    public class Board
    {
        public int Size { get; private set; }
        public Dictionary<int, Snake> Snakes { get; private set; }
        public Dictionary<int, Ladder> Ladders { get; private set; }

        public Board(int size, Snake[] snakes, Ladder[] ladders)
        {
            Size = size;
            Snakes = new Dictionary<int, Snake>();

            for (int i = 0; i < snakes.Length; i++)
            {
                Snakes.Add(snakes[i].Head, snakes[i]);
            }

            Ladders = new Dictionary<int, Ladder>();
            for (int i = 0; i < ladders.Length; i++)
            {
                Ladders.Add(ladders[i].Bottom, ladders[i]);
            }
        }
    }
}
