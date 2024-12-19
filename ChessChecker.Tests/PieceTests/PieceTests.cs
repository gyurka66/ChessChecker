using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker.Tests.PieceTests
{
    [TestFixture]
    public class PieceTests
    {
        private class MockPiece(IPiece.PlayerColor col) : Piece(col)
        {
            public override List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition)
            {
                return [];
            }
        }

        [Test]
        public void ShouldBeWhite()
        {
            Piece piece = new MockPiece(IPiece.PlayerColor.White);
            Assert.That(piece.Color, Is.EqualTo(IPiece.PlayerColor.White));
        }

        [Test]
        public void ShouldBeBlack()
        {
            Piece piece = new MockPiece(IPiece.PlayerColor.Black);
            Assert.That(piece.Color, Is.EqualTo(IPiece.PlayerColor.Black));
        }
    }
}
