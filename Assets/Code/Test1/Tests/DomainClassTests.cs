using NUnit.Framework;
using Katas.Test1.Runtime;
using FluentAssertions;

namespace Test1.Tests
{
    public class DomainClassTests
    {
        [Test]
        public void Sum()
        {
            var sut = new DomainClass();

            sut.Suma(2, 4).Should().Be(6);
        }
    }
}