namespace SampleEFProject.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Dealer { get; set; }
        public string Description { get; set; }
        public GameType Game { get; set; }
    }


    public enum GameType
    {
        TwoTwoTexas = 22,
        TwoFiveTexas = 25,
        FiveFivePot = 5500,
        FiveTenTexas = 510,
        FiveTenPot = 5100
    }
}
