using SnakeLadderLLD.Exceptions;

namespace SnakeLadderLLD.Models
{
    public class Game
    {
        private static int counter = 1;
        public Board Board { get; private set; }
        public Dictionary<int, int> PlayersPositionMap { get; private set; }
        public int Id { get; internal set; }

        // constructor
        public Game(Board board, int[] playerIds)
        {
            Id = counter++;
            Board = board;
            PlayersPositionMap = new Dictionary<int, int>();
            for (int i = 0; i < playerIds.Length; i++)
            {
                PlayersPositionMap.Add(playerIds[i], 0);
            }
        }

        // function to roll the dice
        public static int RollDice()
        {
            Random random = new();
            return random.Next(1, 7);
        }

        // function to move one player
        public int Move(int playerId)
        {
            if (!PlayersPositionMap.ContainsKey(playerId))
            {
                // throw a custom exception
                throw new PlayerNotFoundException($"Player {playerId} does not exist");
            }

            int roll = RollDice();
            int newPosition = PlayersPositionMap[playerId] + roll;

            if (newPosition > Board.Size)
            {
                // No change in position
                return -1;
            }

            PlayersPositionMap[playerId] = newPosition;

            // check if updated position is a ladder bottom
            if (Board.Ladders.ContainsKey(newPosition))
            {
                PlayersPositionMap[playerId] = Board.Ladders[newPosition].Top;
                Console.WriteLine($"Player {playerId} has climbed up the ladder from {newPosition} to {PlayersPositionMap[playerId]}");
            }

            // check if updated position is a snake head
            if (Board.Snakes.ContainsKey(newPosition))
            {
                PlayersPositionMap[playerId] = Board.Snakes[newPosition].Tail;
                Console.WriteLine($"Player {playerId} has a slide down the snake from {newPosition} to {PlayersPositionMap[playerId]}");
            }

            // check if updated position is the last cell
            if (newPosition == Board.Size)
            {
                throw new GameOverException($"Player {playerId} has won the Game. Game Over!");
            }

            return -1;
        }
    }
}
