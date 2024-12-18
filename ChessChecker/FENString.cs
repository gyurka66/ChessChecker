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
        public readonly string piecePlacement;
        public readonly string activeColour;
        public readonly string castlingRights;
        public readonly string enPassentTargets;
        public readonly string halfmoveClock;

        public readonly string fullmoveNumber;
        public FENString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("FENString input was null or empty");
            }
            return;
        }
    }
}
