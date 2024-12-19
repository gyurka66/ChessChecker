using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker
{
    public interface IGameStateFactory
    {
        public GameState CreateGameState();
    }

    public class GameStateFactory(IFENString FENString) : IGameStateFactory
    {
        private readonly IFENString? _FENString = FENString;

        public GameState CreateGameState()
        {
            if (_FENString == null)
            {
                throw new ArgumentException("FEN String was empty");
            }
            return null;
        }
    }
}
