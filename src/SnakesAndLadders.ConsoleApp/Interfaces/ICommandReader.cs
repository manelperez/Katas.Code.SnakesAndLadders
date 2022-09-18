using SnakesAndLadders.Application.ViewModels;

namespace SnakesAndLadders.ConsoleApp.Interfaces
{
    public interface ICommandReader
    {
        int ReadNumberOfPlayers();
        void PlayerRollsDie(int currentPlayer);
        void ShowMove(GameDto model);
    }
}