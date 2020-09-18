using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithComposition
{
    class Bounce : IEdgeHandler
    {
        public void Handle(Piece piece)
        {
            if (piece.Row <= 0)
            {
                piece.SpeedRow = -piece.SpeedRow;
                piece.Row = 0;
            }
            if (piece.Row >= Console.WindowHeight - 1)
            {
                piece.SpeedRow = -piece.SpeedRow;
                piece.Row = Console.WindowHeight - 1;
            }
            if (piece.Col <= 0)
            {
                piece.SpeedCol = -piece.SpeedCol;
                piece.Col = 0;
            }
            if (piece.Col >= Console.WindowWidth - 1)
            {
                piece.SpeedCol = -piece.SpeedCol;
                piece.Col = Console.WindowWidth - 1;
            }
        }
    }
}
