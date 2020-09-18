using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MovingPieceInterfaceIntro.WithInheritance
{
    class BouncePiece : Piece
    {
        public BouncePiece(char symbol, int speedRow, int speedCol) 
            : base(symbol, speedRow, speedCol)
        {
        }

        public override void Move()
        {
            base.Move();
            if (_row <= 0)
            {
                _speedRow = -_speedRow;
                _row = 0;
            }
            if (_row >= Console.WindowHeight - 1)
            {
                _speedRow = -_speedRow;
                _row = Console.WindowHeight - 1;
            }
            if (_col <= 0)
            {
                _speedCol = -_speedCol;
                _col = 0;
            }
            if (_col >= Console.WindowWidth - 1)
            {
                _speedCol = -_speedCol;
                _col = Console.WindowWidth - 1;
            }
        }
    }
}
