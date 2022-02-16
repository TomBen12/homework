using System;
namespace Tom_Class_Types
{//Question n7
    public sealed class GameBoard
    {
        public string width { get; set; }
        public double lenght { get; set; }

        public GameBoard()
        {
        }
        public void ClearBoard()
        {
            Console.WriteLine("The board is cleared");
        }
    }
}