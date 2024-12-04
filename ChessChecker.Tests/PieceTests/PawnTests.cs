using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker.Tests.PieceTests
{
    [TestFixture]
    public class PawnTests
    {
        [Test]
        public void ShouldReturnPossibleMovesOnEmptyBoard()
        {
            // Initialize Board
            Square[,] board = new Square[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new Square();
                }
            }

            PossibleMovesForWhite(board);
            PossibleMovesForBlack(board);

        }

        private void PossibleMovesForBlack(Square[,] board)
        {
            Piece piece = new Pawn(PlayerColor.Black);

            // Cases
            // On left border of board
            (int, int) piecePosition = (0, 1);

            List<Square> moves = piece.PossibleMoves(board, piecePosition);

            Assert.Contains(board[1, 0], moves);

            piecePosition = (2, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[1, 2], moves);
            Assert.Contains(board[3, 2], moves);

            // on Right border of board
            piecePosition = (7, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[6, 2], moves);

            // at the end of board
            piecePosition = (4, 0);
            moves = piece.PossibleMoves(board, piecePosition);
        }

        private void PossibleMovesForWhite(Square[,] board)
        {
            Piece piece = new Pawn(PlayerColor.White);

            // Cases
            // On left border of board
            (int, int) piecePosition = (0, 1);

            List<Square> moves = piece.PossibleMoves(board, piecePosition);

            Assert.Contains(board[1, 2], moves);

            // in Middle of board
            piecePosition = (2, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[1, 4], moves);
            Assert.Contains(board[3, 4], moves);

            // on Right border of board
            piecePosition = (7, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[6, 4], moves);

            // at the end of board
            piecePosition = (4, 7);
            moves = piece.PossibleMoves(board, piecePosition);
        }
    }
}
