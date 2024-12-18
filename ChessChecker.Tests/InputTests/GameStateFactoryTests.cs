using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace ChessChecker.Tests.InputTests
{
    [TestFixture]
    public class GameStateFactoryTests
    {
        private IFENString? _mockFEN;

        [SetUp]
        public void Setup()
        {
            _mockFEN = Substitute.For<IFENString>();
        }

        [Test]
        public void ShouldThrowExceptionOnNullInput()
        {
            IFENString? input = null;
            GameStateFactory sut = new GameStateFactory(null);
            Assert.Throws<ArgumentException>(() => sut.CreateGameState());
        }
    }
}
