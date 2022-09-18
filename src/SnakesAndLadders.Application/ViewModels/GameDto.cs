namespace SnakesAndLadders.Application.ViewModels
{
    public class GameDto
    {
        public int NumberOfPlayers { get; set; }
        public int DieValue { get; set; }
        public int CurrentPlayer { get; set; }
        public int Square { get; set; }
        public bool HasWinner { get; set; }
    }
}
