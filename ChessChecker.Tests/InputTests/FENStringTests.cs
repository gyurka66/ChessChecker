using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker.Tests.InputTests
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

        [TestCase("r w - - 0 0")]
        [TestCase("rnbqkbnr/pppppppp/9/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0")]
        [TestCase("gnbqkbnr/pppppppp/9/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0")]
        public void ShouldThrowExceptionOnInvalidPiecePlacement(string input)
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

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0", ExpectedResult = "-")]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 0 1", ExpectedResult = "-")]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1",
            ExpectedResult = "e3"
        )]
        public string ShouldFillEnPassantTargetsOnValidInput(string input)
        {
            return new FENString(input).EnPassantTargets;
        }

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0", ExpectedResult = 0)]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 20 1", ExpectedResult = 20)]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 99 1",
            ExpectedResult = 99
        )]
        public int ShouldFillHalfMoveClockOnValidInput(string input)
        {
            return new FENString(input).HalfmoveClock;
        }

        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 0 0", ExpectedResult = 0)]
        [TestCase("4k2r/6r1/8/8/8/8/3R4/R3K3 w Qk - 20 1", ExpectedResult = 1)]
        [TestCase(
            "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 99",
            ExpectedResult = 99
        )]
        public int ShouldFillFullMoveNumberOnValidInput(string input)
        {
            return new FENString(input).FullmoveNumber;
        }
    }
}
