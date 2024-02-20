using FluentAssertions;
using FunctionalProgramming.Domain.CustomLinq;
using NUnit.Framework;
using System;
using System.Linq;

namespace FunctionalProgramming.CustomLinq.Test
{
    public class TakeWhileTests
    {
        [Test]
        public void TakeWhile()
        {
            new int[] { 1, 2, 3, 4, 5 }.CTakeWhile(x => x <= 3)
                .Should().Equal(new int[] { 1, 2, 3 });
        }

        [Test]
        public void TakeWhile_StopsOnFirstTime_ConditionFails()
        {
            new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 }.CTakeWhile(x => x <= 3)
                .Should().Equal(new int[] { 1, 2, 3 });
        }

        [Test]
        public void TakeNone()
        {
            new int[] { 3, 4, 5 }.CTakeWhile(x => x < 3).Should().Equal(Enumerable.Empty<int>());
        }

        [Test]
        public void TakeAll()
        {
            var sequence = new int[] { 1, 2, 3, 4, 5 };
            sequence.CTakeWhile(x => x < 10).Should().Equal(sequence);
        }

        [Test, Description("Este es el test que propone la kata para considerarla resuelta")]
        public void KataTest()
        {
            Func<int, bool> IsAnEvenNumber = x => x % 2 == 0;
            var sequence = new int[] { 2, 4, 6, 8, 1, 2, 5, 4, 3, 2 };

            sequence.TakeWhile(IsAnEvenNumber).Should().Equal(new int[] { 2, 4, 6, 8 });
        }
    }
}
