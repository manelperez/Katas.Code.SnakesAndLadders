using SnakesAndLadders.Application.ViewModels;

namespace SnakesAndLadders.Application.Services.Interfaces
{
    public interface ISnakesAndLaddersService
    {
        GameDto Start(int numberOfPlayers);
        int DiceRoll();
        GameDto Move(int currentPlayer, int spaces);
        GameDto NextPlayer();
    }
}