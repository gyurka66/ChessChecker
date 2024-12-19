using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;

namespace ChessChecker.Tests.PieceTests
{
    [TestFixture]
    public class SquareTests
    {
        private Piece? _mockPieceA;
        private Piece? _mockPieceB;

        [SetUp]
        public void Setup()
        {
            _mockPieceA = Substitute.For<Piece>();
            _mockPieceA.Color.Returns(IPiece.PlayerColor.White);
            _mockPieceB = Substitute.For<Piece>();
            _mockPieceB.Color.Returns(IPiece.PlayerColor.Black);
        }

        [Test]
        public void ShouldConstructWithNullPiece()
        {
            Square square = new(null);
            Assert.That(square.Piece, Is.Null);
        }

        [Test]
        public void ShouldConstructWithRealPiece()
        {
            Square square = new(_mockPieceA);
            Assert.That(square.Piece, Is.EqualTo(_mockPieceA));
        }

        [Test]
        public void ShouldThrowExceptionWhenTryingToReplacePiece()
        {
            Square square = new(_mockPieceA);
            Assert.Throws<ApplicationException>(() => square.Piece = _mockPieceB);
        }
    }
}
