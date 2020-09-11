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
        private char _symbol;

        public Piece(char symbol, int speedRow, int speedCol)
        {
            _symbol = symbol;
            _speedRow = speedRow;
            _speedCol = speedCol;
        }

        public void Move()
        {
            _row += _speedRow;
            _col += _speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight) _speedRow = -_speedRow;
            if (_col <= 0 || _col >= Console.WindowWidth) _speedCol = -_speedCol;
        }

        public void Show()
        {
            Console.CursorTop = _row;
            Console.CursorLeft = _col;
            Console.Write(_symbol);
        }
    }
}
