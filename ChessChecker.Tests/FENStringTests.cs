using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessChecker.Tests
{
    [TestFixture]
    public class FENStringTests
    {
        private FENString? _sut;

        [Test]
        public void ShouldThrowExceptionOnNullInput()
        {
            string? input = null;
            Assert.Throws<ArgumentException>(() => new FENString(input));
        }
    }
}
