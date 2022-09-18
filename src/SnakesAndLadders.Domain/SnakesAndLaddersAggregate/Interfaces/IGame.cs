using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.ValueObjects;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces
{
    public interface IGame : IAggregateRoot
    {
        List<IToken> Tokens { get; set; }
        DiceRoll Dice { get; set; }

        void AddPlayers(int numberOfPlayers);
        int DiceRoll();
    }
}
