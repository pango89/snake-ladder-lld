namespace SnakeLadderLLD.Models
{
    public class Player
    {
        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
