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

        [TestCase(Cardinal.N, Cardinal.E)]
        [TestCase(Cardinal.W, Cardinal.N)]
        [TestCase(Cardinal.S, Cardinal.W)]
        [TestCase(Cardinal.E, Cardinal.S)]
        public void TurnRight(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(1, 1, starting);

            sut.Execute("R");

            sut.X.Should().Be(1);
            sut.Y.Should().Be(1);
            sut.LookingAt.Should().Be(result);
        }
    }
}
