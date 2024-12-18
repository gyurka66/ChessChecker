using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        public int HalfmoveClock { get; init; }
        public int FullmoveNumber { get; init; }

        public FENString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("FENString input was null or empty");
            }
            var fields = input.Split(" ");
            if (fields.Length != 6)
            {
                throw new ArgumentException("FENString did not contain all six fields");
            }
            if (!VerifyPiecePlacement(fields[0]))
            {
                throw new ArgumentException("Proposed Piece Plaement was invalid");
            }
            PiecePlacement = fields[0];
            ActiveColour = fields[1];
            CastlingRights = fields[2];
            EnPassantTargets = fields[3];
            HalfmoveClock = int.Parse(fields[4]);
            FullmoveNumber = int.Parse(fields[5]);
            return;
        }

        private bool VerifyPiecePlacement(string proposedPiecePlacement)
        {
            GeneratedRegexAttribute regex = new("([rnbqkp/1-8])+");
            return regex.Match(proposedPiecePlacement);
        }
    }
}
