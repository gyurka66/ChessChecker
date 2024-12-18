using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker
{
    /// <summary>
    /// String used to encode the current state of a chess game.
    /// https://www.chess.com/terms/fen-chess
    /// </summary>
    public class FENString
    {
        public string PiecePlacement { get; init; }
        public string ActiveColour { get; init; }
        public string CastlingRights { get; init; }
        public string EnPassantTargets { get; init; }
        public string HalfmoveClock { get; init; }
        public string FullmoveNumber { get; init; }

        public FENString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("FENString input was null or empty");
            }
            var fields = input.Split(" ");
            PiecePlacement = fields[0];
            ActiveColour = fields[1];
            return;
        }
    }
}
