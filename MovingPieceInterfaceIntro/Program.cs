using System;
using System.Drawing;
using System.Threading;
using MovingPieceInterfaceIntro.WithInheritance;

namespace MovingPieceInterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                IPiece p = null;
                p.Move();
                p.Show();                          
             */
            Console.ForegroundColor = ConsoleColor.Yellow;
            //var pieces = new[]
            //{
            //    new BouncePiece('T', 2, 1),
            //    new BouncePiece('#', 1, 3),
            //};
            //var pieces = new[]
            //{
            //    new TeleportationPiece('T', 2, 1),
            //    new TeleportationPiece('#', 1, 3),
            //};
            var bouncePiece = new BouncePiece('B', 2, 1);
            var teleportationPiece = new TeleportationPiece('T', 1, 3);
            var pieces = new Piece[]{
                    bouncePiece,
                    teleportationPiece,
                };
            while (true)
            {
                Console.Clear();
                foreach (Piece piece in pieces)
                {
                    piece.Move();
                    piece.Show();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(300);
            }
        }
    }
}
