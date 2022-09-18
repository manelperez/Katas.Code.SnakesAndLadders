using SnakesAndLadders.Application.Mappers;
using SnakesAndLadders.Application.Services.Interfaces;
using SnakesAndLadders.Application.ViewModels;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Application.Services
{
    public class SnakesAndLaddersService : ISnakesAndLaddersService
    {
        private IGame game;

        public SnakesAndLaddersService()
        {
            game = new Game();
        }

        public GameDto Start(int numberOfPlayers)
        {
            game.AddPlayers(numberOfPlayers);
            return GameMapper.ModelFromEntity(game);
        }

        public int DiceRoll()
        {
            return game.DiceRoll();
        }

        public GameDto Move(int currentPlayer, int spaces)
        {
            game.Tokens[currentPlayer - 1].Move(spaces);
            return GameMapper.ModelFromEntity(game);
        }

        public GameDto NextPlayer()
        {
            game.NextPlayer();
            return GameMapper.ModelFromEntity(game);
        }
    }
}
