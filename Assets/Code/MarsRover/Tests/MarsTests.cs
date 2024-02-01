using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class MarsTests
    {
        [Test]
        public void CreateMars()
        {
            var sut = new Mars(5, 5);
            
            sut.MaxX.Should().Be(5);
            sut.MaxY.Should().Be(5);
        }

        [TestCase(0, 0, true)]
        [TestCase(5, 5, true)]
        [TestCase(2, 4, true)]
        [TestCase(-1, 2, false)]
        [TestCase(2, -2, false)]
        [TestCase(-3, -4, false)]
        [TestCase(6, 4, false)]
        [TestCase(3, 7, false)]
        [TestCase(7, 9, false)]
        public void IsValidPosition(int posX, int posY, bool result)
        {
            var sut = new Mars(5, 5);

            sut.IsValidPosition(1, 1).Should().BeTrue();
        }
    }
}
