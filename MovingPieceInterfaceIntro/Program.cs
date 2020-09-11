using System;
using System.Drawing;
using System.Threading;

namespace MovingPieceInterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var piece = new Piece('T', 2, 1);
            while (true)
            {
                piece.Move();
                Console.Clear();
                piece.Show();
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(20);
            }
        }
    }
}
