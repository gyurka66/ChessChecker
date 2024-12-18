using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker.Tests.PieceTests
{
    [TestFixture]
    public class KnightTests
    {
        /*
        [Test]
        public void ShouldReturnPossibleMovesOnEmptyBoard()
        {
            Piece piece = new Knight(PlayerColor.Black);

            // Initialize Board
            Square[,] board = new Square[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new Square();
                }
            }

            // Cases
            // On left border of board
            (int, int) piecePosition = (0, 3);

            List<Square> moves = piece.PossibleMoves(board, piecePosition);

            Assert.Contains(board[1, 5], moves);
            Assert.Contains(board[1, 1], moves);
            Assert.Contains(board[2, 4], moves);
            Assert.Contains(board[2, 2], moves);


            //Center
            piecePosition = (3, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[1, 2], moves);
            Assert.Contains(board[1, 4], moves);
            Assert.Contains(board[5, 2], moves);
            Assert.Contains(board[5, 4], moves);
            Assert.Contains(board[4, 1], moves);
            Assert.Contains(board[4, 5], moves);
            Assert.Contains(board[2, 1], moves);
            Assert.Contains(board[2, 5], moves);
            Assert.Contains(board[1, 2], moves);
            Assert.Contains(board[1, 4], moves);

            // on Right border of board
            piecePosition = (7, 3);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[6, 5], moves);
            Assert.Contains(board[6, 1], moves);
            Assert.Contains(board[5, 4], moves);
            Assert.Contains(board[5, 2], moves);

            // on top border of board
            piecePosition = (3, 7);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[5, 6], moves);
            Assert.Contains(board[1, 6], moves);
            Assert.Contains(board[4, 5], moves);
            Assert.Contains(board[2, 5], moves);

            // on down border of board
            piecePosition = (3, 0);
            moves = piece.PossibleMoves(board, piecePosition);
            Assert.Contains(board[5, 1], moves);
            Assert.Contains(board[1, 1], moves);
            Assert.Contains(board[4, 2], moves);
            Assert.Contains(board[2, 2], moves);
        }
        */
    }
}
