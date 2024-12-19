using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;

namespace ChessChecker.Tests.InputTests
{
    [TestFixture]
    public class GameStateTests
    {
        private IGameStateFactory? _mockFactory;
        private IPiece? _mockPiece;
        private IWritable? _mockOutput;

        [SetUp]
        public void SetUp()
        {
            _mockOutput = Substitute.For<IWritable>();
            Square[,] emptyBoard = new Square[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    emptyBoard[i, j] = new Square(null);
                }
            }
            GameState emptyGameState = new(emptyBoard, IPiece.PlayerColor.White, _mockOutput);
            _mockFactory = Substitute.For<IGameStateFactory>();
            _mockFactory.CreateGameState().Returns(emptyGameState);

            _mockPiece = Substitute.For<IPiece>();
            _mockPiece.Color.Returns(IPiece.PlayerColor.White);
        }

        [Test]
        public void ShouldThrowExceptionOnNullBoard()
        {
            Assert.Throws<NullReferenceException>(
                () => new GameState(null, IPiece.PlayerColor.Black, _mockOutput!)
            );
        }

        [Test]
        public void ShouldNotThrowExceptionOnValidBoard()
        {
            Assert.DoesNotThrow(
                () => new GameState(new Square[8, 8], IPiece.PlayerColor.White, _mockOutput!)
            );
        }

        [Test]
        public void AddToSquareShouldThrowExceptionOnNullPiece()
        {
            GameState gameState = _mockFactory!.CreateGameState();

            Assert.Throws<ArgumentException>(() => gameState.AddToSquare(null, (1, 1)));
            _mockOutput!.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [TestCase([9, 1])]
        [TestCase([1, 9])]
        [TestCase([9, 9])]
        [TestCase([-1, 0])]
        [TestCase([0, -1])]
        public void AddToSquareShouldThrowExceptionOnInvalidPosition(int f, int r)
        {
            GameState gameState = _mockFactory!.CreateGameState();
            Assert.Throws<ArgumentException>(() => gameState.AddToSquare(_mockPiece!, (f, r)));
            _mockOutput!.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void AddToSquareShouldWriteToOutputOnAddition()
        {
            GameState gameState = _mockFactory!.CreateGameState();
            gameState.AddToSquare(_mockPiece!, (1, 1));
            _mockOutput!.Received().WriteLine(Arg.Any<string>());
        }
    }
}
