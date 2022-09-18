namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate.ValueObjects
{
    public readonly struct DiceRoll
    {
        public int Value { get; }

        public DiceRoll()
        {
            Value = new Random().Next(1, 7);
        }
    }
}
