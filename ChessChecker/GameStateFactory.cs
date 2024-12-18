using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class GameStateFactory
    {
        public GameState CreateGameState(string fenString)
        {
            if (string.IsNullOrEmpty(fenString))
            {
                throw new ArgumentException("FEN String was empty");
            }
            return null;
        }
    }
}