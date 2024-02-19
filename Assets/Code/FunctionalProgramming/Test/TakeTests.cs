using FluentAssertions;
using FunctionalProgramming.Domain;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.Test
{
    public class TakeTests
    {
        [Test]
        public void TakeZero()
        {
            new int[] { 1, 2, 3, 4 }.CTake(0)
                .Should().Equal(Enumerable.Empty<int>());
        }

        [Test]
        public void TakeAmount()
        {
            new int[] { 1, 2, 3, 4, 5 }.CTake(3)
                .Should().Equal(new int[] { 1, 2, 3 });
        }

        [Test]
        public void TakeAll()
        {
            var sequence = new int[] { 1, 2, 3, 4, 5 };

            sequence.CTake(sequence.Count())
                .Should().Equal(sequence);
        }
    }
}
