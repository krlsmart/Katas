using FluentAssertions;
using FunctionalProgramming.Domain;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.Test
{
    public class CustomLinqTests
    {
        [Test]
        public void TakeZero()
        {
            CustomLinq.Take(new int[] { 1, 2, 3, 4 }, 0)
                .Should().Equal(Enumerable.Empty<int>());
        }

        [Test]
        public void TakeAmount()
        {
            CustomLinq.Take(new int[] { 1, 2, 3, 4, 5 }, 3)
                .Should().Equal(new int[] { 1, 2, 3 });
        }

        [Test]
        public void TakeAll()
        {
            var sequence = new int[] { 1, 2, 3, 4, 5 };

            CustomLinq.Take(sequence, sequence.Count())
                .Should().Equal(sequence);
        }
    }
}
