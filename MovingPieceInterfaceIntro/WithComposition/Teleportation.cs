using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithComposition
{
    class Teleportation : IEdgeHandler
    {
        public void Handle(Piece piece)
        {
            if (piece.Row <= 0) piece.Row += Console.WindowHeight;
            if (piece.Row >= Console.WindowHeight) piece.Row -= Console.WindowHeight;
            if (piece.Col <= 0) piece.Col += Console.WindowWidth;
            if (piece.Col >= Console.WindowWidth) piece.Col -= Console.WindowWidth;
        }
    }
}
