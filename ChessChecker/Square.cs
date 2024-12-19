using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class Square
    {
        public Piece? Piece { get; set; }

        public Square(Piece? piece)
        {
            Piece = piece;
        }
    }
}
