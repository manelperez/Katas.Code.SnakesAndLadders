namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces
{
    public interface IGame : IAggregateRoot
    {
        List<IToken> Tokens { get; set; }

        void AddPlayers(int numberOfPlayers);
    }
}
