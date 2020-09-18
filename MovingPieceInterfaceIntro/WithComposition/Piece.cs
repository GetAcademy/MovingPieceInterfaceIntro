using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithComposition
{
    class Piece
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int SpeedRow { get; set; }
        public int SpeedCol { get; set; }
        public char _symbol;
        private IEdgeHandler _edgeHandler;


        public Piece(char symbol, int speedRow, int speedCol, IEdgeHandler edgeHandler)
        {
            _edgeHandler = edgeHandler;
            _symbol = symbol;
            SpeedRow = speedRow;
            SpeedCol = speedCol;
        }

        public void Move()
        {
            Row += SpeedRow;
            Col += SpeedCol;
            _edgeHandler.Handle(this);
        }

        public void Show()
        {
            Console.CursorTop = Row;
            Console.CursorLeft = Col;
            Console.Write(_symbol);
        }
    }
}
