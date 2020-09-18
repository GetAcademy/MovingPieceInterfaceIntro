using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithInheritance
{
    class TeleportationPiece : Piece
    {
        public TeleportationPiece(char symbol, int speedRow, int speedCol)
            : base(symbol, speedRow, speedCol)
        {
            
        }

        public override void Move()
        {
            base.Move();
            if (_row <= 0) _row += Console.WindowHeight;
            if (_row >= Console.WindowHeight) _row -= Console.WindowHeight;
            if (_col <= 0) _col += Console.WindowWidth;
            if (_col >= Console.WindowWidth) _col -= Console.WindowWidth;

        }
    }
}
