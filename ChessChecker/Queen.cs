﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class Queen : Piece
    {
        public override List<Square> PossibleMoves(Square[,] board, (int, int) piecePosition)
        {
            throw new NotImplementedException();
        }
    }
}
