using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class FENString
    {
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
