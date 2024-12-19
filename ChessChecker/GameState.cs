using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
    public class GameState
    {
        //private const int BOARD_WIDTH = 8;
        //private const int BOARD_HEIGHT = 8;

        private Square[,] _board;

        private IPiece.PlayerColor _activeColour;

        public GameState(Square[,] board, IPiece.PlayerColor color)
        {
            _board = board ?? throw new NullReferenceException("Supplied an empty board array");
            _activeColour = color;
        }

        public void AddToSquare(IPiece piece, (int f, int r) position)
        {
            if (piece == null)
            {
                throw new ArgumentException("Can't add a null piece");
            }
        }
    }
}
