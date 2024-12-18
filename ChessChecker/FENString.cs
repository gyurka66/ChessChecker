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
            if (input == null)
            {
                throw new ArgumentException("FENString input was null");
            }
            return;
        }
    }
}
