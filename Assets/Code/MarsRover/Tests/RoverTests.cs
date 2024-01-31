using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class RoverTests
    {
        [Test]
        public void TurnLeft()
        {
            var sut = new Rover(1, 1, Cardinal.N);

            sut.Execute("L");

            sut.X.Should().Be(1);
            sut.Y.Should().Be(1);
            sut.Facing.Should().Be(Cardinal.W);
        }
    }
}
