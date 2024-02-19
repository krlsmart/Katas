using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain
{
    public class CustomLinq
    {
        public static IEnumerable<int> Take(IEnumerable<int> values, int amount)
        {
            return IterateElements(values, 0, (index) => index < amount);
        }

        static IEnumerable<int> IterateElements(IEnumerable<int> values, int index, Func<int, bool> condition)
        {
            if(index < values.Count())
            {
                var result = IterateElements(values, index + 1, condition);

                return condition(index)
                    ? result.Prepend(values.ElementAt(index))
                    : result;
            }

            return Enumerable.Empty<int>();
        }
    }
}
