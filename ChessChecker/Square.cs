using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class Square
    {
        private IPiece? _piece;
        public IPiece? Piece
        {
            get => _piece;
            set
            {
                if (_piece == null)
                {
                    _piece = value;
                }
                else
                {
                    throw new ApplicationException(
                        "Can't put a piece on a filled square. Remove the existing piece first."
                    );
                }
            }
        }

        public Square(IPiece? piece)
        {
            Piece = piece;
        }
    }
}
