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
            var pieces = new[]
            {
                new BouncePiece('T', 2, 1),
                new BouncePiece('#', 1, 3),
            };
            //var pieces = new[]
            //{
            //    new TeleportationPiece('T', 2, 1),
            //    new TeleportationPiece('#', 1, 3),
            //};
            while (true)
            {
                Console.Clear();
                foreach (var piece in pieces)
                {
                    piece.Move();
                    piece.Show();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(20);
            }
        }
    }
}
