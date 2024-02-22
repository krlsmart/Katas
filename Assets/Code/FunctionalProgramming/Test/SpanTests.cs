using FluentAssertions;
using FunctionalProgramming.Domain.CustomLinq;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.CustomLinq.Test
{
    public class SpanTests
    {
        [Test]
        public void CSpan()
        {
            var sequence = new int[] { 1, 9, 4, 12, 2, 1 };

            var result = sequence.CSpan(x => x < 10);

            result.first.Should().Equal(new int[] { 1, 9, 4 });
            result.last.Should().Equal(new int[] { 12, 2, 1 });
        }

        [Test]
        public void AllElements_MeetCondition()
        {
            var sequence = new int[] { 2, 4, 6, 1, 5 };

            var result = sequence.CSpan(x => x < 100);

            result.first.Should().Equal(sequence);
            result.last.Should().Equal(Enumerable.Empty<int>());
        }

        [Test]
        public void FirstElement_DoNotMeetCondition()
        {
            var sequence = new int[] { 2, 4, 6, 1, 5 };

            var result = sequence.CSpan(x => x < 1);

            result.first.Should().Equal(Enumerable.Empty<int>());
            result.last.Should().Equal(sequence);
        }


        [Test, Description("Este es el test que propone la kata para considerarla resuelta")]
        public void KataTest()
        {
            static bool IsAnEvenNumber(int x) => x % 2 == 0;
            var sequence = new int[] { 2, 4, 6, 1, 8, 10 };

            var result = sequence.CSpan(IsAnEvenNumber);

            result.first.Should().Equal(new int[] { 2, 4, 6 });
            result.last.Should().Equal(new int[] { 1, 8, 10 });
        }
    }
}
