using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain
{
    public class CustomLinq
    {
        public static IEnumerable<int> Take(IEnumerable<int> values, int amount)
        {
            return IterateElements(values, (index) => index < amount);
        }

        static IEnumerable<int> IterateElements(IEnumerable<int> values, Func<int, bool> condition, int index = 0)
        {
            if(index < values.Count())
            {
                var result = IterateElements(values, condition, index + 1);

                return condition(index)
                    ? new int[] {values.ElementAt(index)}.Concat(result)
                    : result;
            }

            return Enumerable.Empty<int>();
        }
    }
}
