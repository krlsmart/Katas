using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class RoverTests
    {
        [TestCase(Cardinal.N, Cardinal.W)]
        [TestCase(Cardinal.W, Cardinal.S)]
        [TestCase(Cardinal.S, Cardinal.E)]
        [TestCase(Cardinal.E, Cardinal.N)]
        public void TurnLeft(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(1, 1, starting);

            sut.Execute("L");

            sut.X.Should().Be(1);
            sut.Y.Should().Be(1);
            sut.LookingAt.Should().Be(result);
        }
    }
}
