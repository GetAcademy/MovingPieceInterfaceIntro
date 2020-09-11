using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro
{
    class Piece
    {
        private int _row;
        private int _col;
        private int _speedRow;
        private int _speedCol;

        public void Move()
        {

        }

        public void Show()
        {
            Console.CursorTop = _row;
            Console.CursorLeft = _col;
        }
    }
}
