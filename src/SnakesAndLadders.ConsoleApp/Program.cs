using SnakesAndLadders.Application.Mappers;
using SnakesAndLadders.Application.Services;
using SnakesAndLadders.Application.Services.Interfaces;
using SnakesAndLadders.ConsoleApp.Controllers;
using SnakesAndLadders.ConsoleApp.Interfaces;

namespace SnakesAndLadders.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IView view = new View();
            ICommandReader commandReader = new CommandReader(view);
            ISnakesAndLaddersService snakesAndLaddersService = new SnakesAndLaddersService();
            var controller = new SnakesAndLaddersController(commandReader, snakesAndLaddersService);
            controller.Run();
        }
    }
}