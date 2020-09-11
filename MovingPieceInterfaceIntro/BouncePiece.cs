using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro
{
    class BouncePiece
    {
        private int _row;
        private int _col;
        private int _speedRow;
        private int _speedCol;
        private char _symbol;

        public BouncePiece(char symbol, int speedRow, int speedCol)
        {
            _symbol = symbol;
            _speedRow = speedRow;
            _speedCol = speedCol;
        }

        public void Move()
        {
            _row += _speedRow;
            _col += _speedCol;
            if (_row <= 0 )
            {
                _speedRow = -_speedRow;
                _row = 0;
            }
            if ( _row >= Console.WindowHeight - 1)
            {
                _speedRow = -_speedRow;
                _row = Console.WindowHeight - 1;
            }
            if (_col <= 0 )
            {
                _speedCol = -_speedCol;
                _col = 0;
            }
            if ( _col >= Console.WindowWidth - 1)
            {
                _speedCol = -_speedCol;
                _col = Console.WindowWidth - 1;
            }
        }

        public void Show()
        {
            Console.CursorTop = _row;
            Console.CursorLeft = _col;
            Console.Write(_symbol);
        }
    }
}
