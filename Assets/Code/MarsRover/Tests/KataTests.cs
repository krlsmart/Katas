using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;
using static MarsRover.Domain.Cardinal;

namespace MarsRover.Test
{
    public class KataTests
    {
        [Test]
        public void FinalTest()
        {
            var mars = new Mars(5, 5);
            var rover1 = new Rover(new Position(1, 2, N), mars);
            var rover2 = new Rover(new Position(3, 3, E), mars);

            rover1.Execute("LMLMLMLMM");
            rover2.Execute("MMRMMRMRRM");

            rover1.Position.Should().Be(new Position(1, 3, N));
            rover2.Position.Should().Be(new Position(5, 1, E));
        }
    }
}
