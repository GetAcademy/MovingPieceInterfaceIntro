using System;
using System.Threading;

namespace MovingPieceInterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var piece = new Piece('#', 2, 1);
            while (true)
            {
                piece.Move();
                Console.Clear();
                piece.Show();
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(50);
            }
        }
    }
}
