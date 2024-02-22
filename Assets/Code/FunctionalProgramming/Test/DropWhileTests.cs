using FluentAssertions;
using FunctionalProgramming.Domain.CustomLinq;
using NUnit.Framework;
using System.Linq;

namespace FunctionalProgramming.CustomLinq.Test
{
    public class DropWhileTests
    {
        [Test]
        public void DropWhile()
        {
            new int[] { 1, 2, 3, 4, 5 }.CDropWhile(x => x <= 2)
                .Should().Equal(new int[] { 3, 4, 5 });
        }

        [Test]
        public void DropNone()
        {
            int[] sequence = new int[] { 1, 2, 3, 4, 5 };
            sequence.CDropWhile(x => x > 10).Should().Equal(sequence);
        }

        [Test]
        public void DropAll()
        {
            new int[] { 1, 2, 3, 4, 5 }.CDropWhile(x => x >= 1)
                .Should().Equal(Enumerable.Empty<int>());
        }

        [Test, Description("Este es el test que propone la kata para considerarla resuelta")]
        public void KataTest()
        {
            static bool IsAnEvenNumber(int x) => x % 2 == 0;
            var sequence = new int[] { 2, 4, 6, 8, 1, 2, 5, 4, 3, 2 };

            var result = sequence.CDropWhile(IsAnEvenNumber);
                
            result.Should().Equal(new int[] { 1, 2, 5, 4, 3, 2 });
        }
    }
}
