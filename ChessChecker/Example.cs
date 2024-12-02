using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class Example(int e)
    {
        public int Num {get; protected set;} = e;

        public bool IsEven() {
            return Num % 2 == 0;
        }

        public bool IsOdd() {
            return Num % 2 == 1;
        }
    }
}