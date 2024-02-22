using FluentAssertions;
using FunctionalProgramming.Domain.CustomLinq;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.CustomLinq.Test
{
    public class SelectTests
    {
        [Test]
        public void Select1()
        {
            var sequence = new[] { 1, 2, 3 };

            sequence.CSelect(MultiplyBy2).Should().Equal(new int[] { 2, 4, 6 });

            static int MultiplyBy2(int value) => value * 2;
        }

        [Test]
        public void SelectOnEmptyCollection_ReturnsEmptyCollection()
        {
            Enumerable.Empty<int>().CSelect(x => x * 2).Should().Equal(Enumerable.Empty<int>());
        }
    }
}
