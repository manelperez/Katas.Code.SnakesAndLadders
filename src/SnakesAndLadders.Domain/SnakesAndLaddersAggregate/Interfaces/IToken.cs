namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces
{
    public interface IToken : IAggregateRoot
    {
        int Square { get; set; }
        bool Winner { get; }
        void Move(int spaces);
    }
}
