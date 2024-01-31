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
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = starting });

            sut.Execute("L");

            sut.Position.Should().Be(new Position { X = 1, Y = 1, LookingAt = result });
        }

        [TestCase(Cardinal.N, Cardinal.E)]
        [TestCase(Cardinal.W, Cardinal.N)]
        [TestCase(Cardinal.S, Cardinal.W)]
        [TestCase(Cardinal.E, Cardinal.S)]
        public void TurnRight(Cardinal starting, Cardinal result)
        {
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = starting });

            sut.Execute("R");

            sut.Position.Should().Be(new Position { X = 1, Y = 1, LookingAt = result });
        }

        [Test]
        public void Move_WhileLookingAt_N()
        {
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = Cardinal.N });

            sut.Execute("M");

            sut.Position.Should().Be(new Position { X = 1, Y = 2, LookingAt = Cardinal.N });
        }

        [Test]
        public void Move_WhileLookingAt_W()
        {
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = Cardinal.W });

            sut.Execute("M");

            sut.Position.Should().Be(new Position { X = 0, Y = 1, LookingAt = Cardinal.W });
        }

        [Test]
        public void Move_WhileLookingAt_S()
        {
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = Cardinal.S });

            sut.Execute("M");

            sut.Position.Should().Be(new Position { X = 1, Y = 0, LookingAt = Cardinal.S });
        }

        [Test]
        public void Move_WhileLookingAt_E()
        {
            var sut = new Rover(new Position { X = 1, Y = 1, LookingAt = Cardinal.E });

            sut.Execute("M");

            sut.Position.Should().Be(new Position { X = 2, Y = 1, LookingAt = Cardinal.E });
        }
    }
}
