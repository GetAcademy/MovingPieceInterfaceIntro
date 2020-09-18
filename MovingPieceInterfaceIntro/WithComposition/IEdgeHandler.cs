using System;
using System.Collections.Generic;
using System.Text;

namespace MovingPieceInterfaceIntro.WithComposition
{
    interface IEdgeHandler
    {
        void Handle(Piece piece);
    }
}
