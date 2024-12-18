using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker.Tests
{
    [TestFixture]
    public class FENStringTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(" ")]
        public void ShouldThrowExceptionOnBlankInput(string? input)
        {
            Assert.Throws<ArgumentException>(() => new FENString(input));
        }
    }
}
