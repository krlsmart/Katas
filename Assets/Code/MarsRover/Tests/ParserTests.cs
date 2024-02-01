using FluentAssertions;
using MarsRover.Domain;
using NUnit.Framework;
using System;
using System.Linq;

namespace MarsRover.Test
{
    public class ParserTests
    {
        [Test]
        public void SplitInput()
        {
            var sut = Parser.Split("abc").ToList();

            sut.Count.Should().Be(3);
            sut[0].Should().Be("a");
            sut[1].Should().Be("b");
            sut[2].Should().Be("c");
        }

        [Test]
        public void Split_NullOrEmptyInput_ThrowsArgumentException()
        {
            Action act1 = () => Parser.Split(null);
            Action act2 = () => Parser.Split(string.Empty);

            Assert.Throws<ArgumentException>(act1.Invoke);
            Assert.Throws<ArgumentException>(act2.Invoke);
        }
    }
}
