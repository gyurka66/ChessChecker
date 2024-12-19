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
        }

        [Test]
        public void ShouldThrowExceptionOnNullBoard()
        {
            Assert.Throws<NullReferenceException>(
                () => new GameState(null, IPiece.PlayerColor.White)
            );
        }
    }
}
