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
        private IPiece? _mockPiece;

        [SetUp]
        public void Setup()
        {
            _mockPiece = Substitute.For<Piece>();
            _mockPiece.Color.Returns(IPiece.PlayerColor.White);
        }

        [Test]
        public void shouldConstructWithNullPiece()
        {
            Square square = new(null);
            Assert.That(square!.Piece, Is.Null);
        }
    }
}
