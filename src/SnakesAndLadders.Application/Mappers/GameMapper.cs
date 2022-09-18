using SnakesAndLadders.Application.ViewModels;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Application.Mappers
{
    public class GameMapper
    {
        public static GameDto ModelFromEntity(IGame game)
        {
            return new GameDto
            {
                NumberOfPlayers = game.Tokens.Count,
                DieValue = game.Dice.Value,
            };
        }

    }
}
