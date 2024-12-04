using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{

    public enum PlayerColor {
        Black,
        White
    }
    public abstract class Piece
    {
        public abstract List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition);
    }
}
