using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker.Tests
{
    [TestFixture]
    public class GameStateFactoryTests
    {
        private GameStateFactory? _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new GameStateFactory();
        }

        [Test]
        public void ShouldThrowExceptionOnEmptyString()
        {
            string input = string.Empty;
            Assert.Throws<ArgumentException>(() => _sut!.CreateGameState(input));
        }
    }
}
