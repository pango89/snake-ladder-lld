using SnakeLadderLLD.Controllers;
using SnakeLadderLLD.Factories;
using SnakeLadderLLD.Models;
using SnakeLadderLLD.Repositories;
using SnakeLadderLLD.Services;

namespace SnakeLadderLLD
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake[] snakes = [
                SnakeFactory.CreateSnake(20, 4),
                SnakeFactory.CreateSnake(50, 6),
                SnakeFactory.CreateSnake(99, 9),
                SnakeFactory.CreateSnake(89, 13),
                SnakeFactory.CreateSnake(75, 18),
                SnakeFactory.CreateSnake(81, 46)
            ];

            Ladder[] ladders = [
                LadderFactory.CreateLadder(2, 40),
                LadderFactory.CreateLadder(5, 60),
                LadderFactory.CreateLadder(30, 85),
                LadderFactory.CreateLadder(70, 95)
            ];

            Board board = BoardFactory.CreateBoard(100, snakes, ladders);

            int playerId1 = 1;
            int playerId2 = 2;

            Game game = new Game(board, new int[] { playerId1, playerId2 });

            IGameRepository gameRepository = new GameRepository();
            IGameService gameService = new GameService(gameRepository);

            GameController gameController = new GameController(gameService);
            gameController.AddGame(game);

            while (true)
            {
                gameController.Move(playerId1, game.Id);
                gameController.DisplayPlayerPositions(game.Id, playerId1);
                gameController.Move(playerId2, game.Id);
                gameController.DisplayPlayerPositions(game.Id, playerId2);
            }
        }
    }
}