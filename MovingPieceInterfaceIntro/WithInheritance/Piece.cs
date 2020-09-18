using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithInheritance
{
    class Piece 
    {
        protected int _row;
        protected int _col;
        protected int _speedRow;
        protected int _speedCol;
        protected char _symbol;

        public Piece(char symbol, int speedRow, int speedCol)
        {
            _symbol = symbol;
            _speedRow = speedRow;
            _speedCol = speedCol;
        }

        public virtual void Move()
        {
            _row += _speedRow;
            _col += _speedCol;
        }

        public void Show()
        {
            Console.CursorTop = _row;
            Console.CursorLeft = _col;
            Console.Write(_symbol);
        }
    }
}
