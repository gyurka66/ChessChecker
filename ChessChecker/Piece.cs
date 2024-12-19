using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public interface IPiece
    {
        public enum PlayerColor
        {
            Black,
            White
        }

        public List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition);
        public PlayerColor Color { get; }
    }

    public abstract class Piece(IPiece.PlayerColor playerColor) : IPiece
    {
        public IPiece.PlayerColor Color { get; init; } = playerColor;

        public abstract List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition);
    }
}
