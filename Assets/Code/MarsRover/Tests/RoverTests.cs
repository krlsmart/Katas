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
            var sut = new Rover(new Position(1, 1, starting));

            sut.Execute("L");

            sut.Position.Should().Be(new Position(1, 1, result));
        }

        [TestCase(Cardinal.N, Cardinal.E)]
        [TestCase(Cardinal.W, Cardinal.N)]
        [TestCase(Cardinal.S, Cardinal.W)]
        [TestCase(Cardinal.E, Cardinal.S)]
        public void TurnRight(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(new Position(1, 1, starting));

            sut.Execute("R");

            sut.Position.Should().Be(new Position(1, 1, result));
        }

        [Test]
        public void Move_WhileLookingAt_N()
        {
            var sut = new Rover(new Position(1, 1, Cardinal.N));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(1, 2, Cardinal.N));
        }

        [Test]
        public void Move_WhileLookingAt_W()
        {
            var sut = new Rover(new Position(1, 1, Cardinal.W));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(0, 1, Cardinal.W));
        }

        [Test]
        public void Move_WhileLookingAt_S()
        {
            var sut = new Rover(new Position(1, 1, Cardinal.S));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(1, 0, Cardinal.S));
        }

        [Test]
        public void Move_WhileLookingAt_E()
        {
            var sut = new Rover(new Position(1, 1, Cardinal.E));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(2, 1, Cardinal.E));
        }
    }
}
