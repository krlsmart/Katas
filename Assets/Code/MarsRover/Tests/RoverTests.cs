using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;
using System;
using static MarsRover.Domain.Cardinal;

namespace MarsRover.Test
{
    public class RoverTests
    {
        [TestCase(N, W)]
        [TestCase(W, S)]
        [TestCase(S, E)]
        [TestCase(E, N)]
        public void TurnLeft(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(new Position(1, 1, starting), new Mars(5, 5));

            sut.Execute("L");

            sut.Position.Should().Be(new Position(1, 1, result));
        }

        [TestCase(N, E)]
        [TestCase(W, N)]
        [TestCase(S, W)]
        [TestCase(E, S)]
        public void TurnRight(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(new Position(1, 1, starting), new Mars(5, 5));

            sut.Execute("R");

            sut.Position.Should().Be(new Position(1, 1, result));
        }

        [Test]
        public void Move_WhileLookingAt_N()
        {
            var sut = new Rover(new Position(1, 1, N), new Mars(5, 5));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(1, 2, N));
        }

        [Test]
        public void Move_WhileLookingAt_W()
        {
            var sut = new Rover(new Position(1, 1, W), new Mars(5, 5));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(0, 1, W));
        }

        [Test]
        public void Move_WhileLookingAt_S()
        {
            var sut = new Rover(new Position(1, 1, S), new Mars(5, 5));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(1, 0, S));
        }

        [Test]
        public void Move_WhileLookingAt_E()
        {
            var sut = new Rover(new Position(1, 1, E), new Mars(5, 5));

            sut.Execute("M");

            sut.Position.Should().Be(new Position(2, 1, E));
        }

        [Test]
        public void CreateRover_InValidPosition()
        {
            var mars = new Mars(5, 5);
            Action act1 = () => new Rover(new Position(1, 1, N), mars);
            Action act2 = () => new Rover(new Position(6, 6, N), mars);

            Assert.DoesNotThrow(act1.Invoke);
            Assert.Throws<ArgumentException>(act2.Invoke);
        }
    }
}
