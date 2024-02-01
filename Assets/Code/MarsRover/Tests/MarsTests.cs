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
    }
}
