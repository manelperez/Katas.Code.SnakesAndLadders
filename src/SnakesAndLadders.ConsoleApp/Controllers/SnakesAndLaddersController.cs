using SnakesAndLadders.Application.Services.Interfaces;
using SnakesAndLadders.Application.ViewModels;
using SnakesAndLadders.ConsoleApp.Interfaces;

namespace SnakesAndLadders.ConsoleApp.Controllers
{
    public class SnakesAndLaddersController
    {
        private readonly ICommandReader _commandReader;
        private readonly ISnakesAndLaddersService _snakesAndLaddersService;

        public SnakesAndLaddersController(ICommandReader commandReader, ISnakesAndLaddersService snakesAndLaddersService)
        {
            _commandReader = commandReader;
            _snakesAndLaddersService = snakesAndLaddersService;
        }

        public void Run()
        {
            int numberOfPlayers = _commandReader.ReadNumberOfPlayers();
            GameDto model = _snakesAndLaddersService.Start(numberOfPlayers);
            while (!model.HasWinner)
            {
                _commandReader.PlayerRollsDie(model.CurrentPlayer);
                int spaces = _snakesAndLaddersService.DiceRoll();
                model = _snakesAndLaddersService.Move(model.CurrentPlayer, spaces);
                _commandReader.ShowMove(model);
                model = _snakesAndLaddersService.NextPlayer();
            }
        }
    }
}