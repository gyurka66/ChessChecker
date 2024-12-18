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

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0")]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 0 1")]
        [TestCase("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1")]
        public void ShouldFillPiecePlacementOnValidInput(string input)
        {
            var actual = new FENString(input);
            Assert.Multiple(() =>
            {
                Assert.That(actual.piecePlacement, Is.Not.Null);
                Assert.That(actual.piecePlacement, Is.Not.Empty);
            });
        }
    }
}
