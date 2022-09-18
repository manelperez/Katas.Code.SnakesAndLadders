using SnakesAndLadders.Application.ViewModels;
using SnakesAndLadders.ConsoleApp.Interfaces;

namespace SnakesAndLadders.ConsoleApp
{
    public class CommandReader : ICommandReader
    {
        private IView _view;

        public CommandReader(IView view)
        {
            _view = view;
        }

        public int ReadNumberOfPlayers()
        {
            _view.Write($"Enter the number of players: ");
            int numberOfPlayers;
            string line = _view.ReadLine();
            if (!int.TryParse(line, out numberOfPlayers))
            {
                numberOfPlayers = 0;
            }
            return numberOfPlayers;
        }

        public void PlayerRollsDie(int currentPlayer)
        {
            _view.LineFeed();
            _view.Write($"player number {currentPlayer}'s turn (press any key to roll die) ...");
            _view.ReadKey();
        }

        public void ShowMove(GameDto game)
        {
            var result = $"{game.DieValue} => player {game.CurrentPlayer} moves to square {game.Square}";
            var win = game.HasWinner ? " and WINS!!" : string.Empty;
            _view.LineFeed();
            _view.WriteLine($"{result}{win}.");
        }
    }
}
