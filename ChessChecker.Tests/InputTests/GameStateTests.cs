using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;

namespace ChessChecker.Tests.InputTests
{
    [TestFixture]
    public class GameStateTests
    {
        private IGameStateFactory? _mockFactory;

        [SetUp]
        public void SetUp()
        {
            _mockFactory = Substitute.For<IGameStateFactory>();
            _mockFactory
                .CreateGameState()
                .Returns(new GameState(new Square[8, 8], IPiece.PlayerColor.White));
        }

        [Test]
        public void ShouldThrowExceptionOnNullBoard()
        {
            Assert.Throws<NullReferenceException>(
                () => new GameState(null, IPiece.PlayerColor.Black)
            );
        }

        [Test]
        public void ShouldNotThrowExceptionOnValidBoard()
        {
            Assert.DoesNotThrow(() => new GameState(new Square[8, 8], IPiece.PlayerColor.White));
        }

        [Test]
        public void AddToSquareShouldThrowExceptionOnNullPiece()
        {
            GameState gameState = _mockFactory!.CreateGameState();

            Assert.Throws<ArgumentException>(() => gameState.AddToSquare(null, (1, 1)));
        }
    }
}
