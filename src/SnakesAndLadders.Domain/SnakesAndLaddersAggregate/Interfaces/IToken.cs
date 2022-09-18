namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces
{
    public interface IToken : IAggregateRoot
    {
        int Square { get; set; }
    }
}
