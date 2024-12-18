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

        [TestCase(
            "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0",
            ExpectedResult = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR"
        )]
        [TestCase(
            "4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 0 1",
            ExpectedResult = "4k2r/6r1/8/8/8/8/3R4/R3K3"
        )]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1",
            ExpectedResult = "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR"
        )]
        public string ShouldFillPiecePlacementOnValidInput(string input)
        {
            return new FENString(input).PiecePlacement;
        }

        [TestCase("w - - 0 0")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR - - 0 0")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - 0 0")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w 0 0")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - -")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR")]
        public void ShouldThrowExceptionOnMissingField(string input)
        {
            Assert.Throws<ArgumentException>(() => new FENString(input));
        }

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0", ExpectedResult = "w")]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 0 1", ExpectedResult = "w")]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1",
            ExpectedResult = "b"
        )]
        public string ShouldFillActiveColourOnValidInput(string input)
        {
            return new FENString(input).ActiveColour;
        }

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0", ExpectedResult = "-")]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 0 1", ExpectedResult = "Qk")]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1",
            ExpectedResult = "KQkq"
        )]
        public string ShouldFillCastlingRightsOnValidInput(string input)
        {
            return new FENString(input).CastlingRights;
        }
    }
}
