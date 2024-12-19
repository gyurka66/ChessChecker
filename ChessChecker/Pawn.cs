using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class Pawn(IPiece.PlayerColor color) : Piece(color)
    {
        public override List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition)
        {
            int verticalOffset = 1;
            if (Color == IPiece.PlayerColor.Black)
            {
                verticalOffset = -1;
            }

            List<Square> moves = [];
            (int, int) leftMove = (piecePosition.Item1 - 1, piecePosition.Item2 + verticalOffset);
            (int, int) rightMove = (piecePosition.Item1 + 1, piecePosition.Item2 + verticalOffset);
            if (
                leftMove.Item1 >= 0
                && leftMove.Item2 >= 0
                && leftMove.Item1 <= 7
                && leftMove.Item2 <= 7
            ) // Make sure move is on table
            {
                moves.Add(board[leftMove.Item1, leftMove.Item2]);
            }
            if (
                rightMove.Item1 >= 0
                && rightMove.Item2 >= 0
                && rightMove.Item1 <= 7
                && rightMove.Item2 <= 7
            ) // Make sure move is on table
            {
                moves.Add(board[rightMove.Item1, rightMove.Item2]);
            }

            return moves;
        }
    }
}
