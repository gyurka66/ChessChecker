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
        public int BoardWidth => _board.GetLength(0);
        public int BoardHeight => _board.GetLength(1);

        private Square[,] _board;

        private IPiece.PlayerColor _activeColour;

        private IWritable _output;

        public GameState(Square[,] board, IPiece.PlayerColor color, IWritable output)
        {
            _board = board ?? throw new NullReferenceException("Supplied an empty board array");
            _activeColour = color;
            _output = output;
        }

        public void AddToSquare(IPiece piece, (int f, int r) position)
        {
            if (piece == null)
            {
                throw new ArgumentException("Can't add a null piece");
            }
            if (!IsPositionInBounds(position))
            {
                throw new ArgumentException("There is no square at that position");
            }
            
        }

        private bool IsPositionInBounds((int f, int r) position)
        {
            bool isFileInBounds = position.f >= 0 && position.f < BoardWidth;
            bool isRankInBounds = position.r >= 0 && position.r < BoardHeight;
            return isFileInBounds && isRankInBounds;
        }
    }
}
