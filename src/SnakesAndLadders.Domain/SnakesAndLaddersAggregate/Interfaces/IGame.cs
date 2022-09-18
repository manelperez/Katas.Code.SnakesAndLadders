using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.ValueObjects;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces
{
    public interface IGame : IAggregateRoot
    {
        List<IToken> Tokens { get; set; }
        DiceRoll Dice { get; set; }
        int CurrentPlayer { get; set; }
        bool HasWinner { get; }

        void AddPlayers(int numberOfPlayers);
        int DiceRoll();
        void NextPlayer();
    }
}
