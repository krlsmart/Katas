using FluentAssertions;
using FunctionalProgramming.Domain;
using NUnit.Framework;

namespace FunctionalProgramming.Test
{
    public class FunctionsTests
    {
        [Test]
        public void MultiplyBy()
        {
            var sut = Functions.MultiplyBy(5);

            var result = sut(new int[] { 1, 2, 3 });

            result.Should().BeEquivalentTo(new int[] {5, 10, 15});

        }

        [Test]
        public void MultiplyBy_InOneLine()
        {
            Functions.MultiplyBy(5)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 5, 10 });
            Functions.MultiplyBy(10)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 10, 20 });
            Functions.MultiplyBy(25)(new int[] { 1, 2 }).Should().BeEquivalentTo(new int[] { 25, 50 });
        }
    }
}
