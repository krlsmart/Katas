using FluentAssertions;
using FunctionalProgramming.Domain;
using NUnit.Framework;

namespace FunctionalProgramming.Test
{
    public class FirstClassTests
    {
        [Test]
        public void MultiplyBy()
        {
            var sut = FirstClass.Factory(5);

            var result = sut(new int[] { 1, 2, 3 });

            result.Should().BeEquivalentTo(new int[] {5, 10, 15});

        }

        [Test]
        public void MultiplyBy_InOneLine()
        {
            FirstClass.Factory(5)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 5, 10 });
            FirstClass.Factory(10)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 10, 20 });
            FirstClass.Factory(25)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 25, 50 });
        }
    }
}
