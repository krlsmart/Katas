using FluentAssertions;
using FunctionalProgramming.Domain.CustomLinq;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.CustomLinq.Test
{
    public class WhereTests
    {
        [Test]
        public void Where()
        {
            var sequence = new int[] { 4, 7, 2, 9 };

            sequence.CWhere(x => x < 5).Should().Equal(new int[] { 4, 2 });
        }

        [Test]
        public void AllElementsMeetsCondition()
        {
            var sequence = new int[] { 4, 7, 2, 9 };

            sequence.CWhere(x => x < 10).Should().Equal(sequence);
        }


        [Test]
        public void NoneElementMeetsCondition()
        {
            var sequence = new int[] { 4, 7, 2, 9 };

            sequence.CWhere(x => x > 20).Should().Equal(Enumerable.Empty<int>());
        }
    }
}
