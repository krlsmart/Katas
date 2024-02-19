using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain
{
    public class CustomLinq
    {
        public static IEnumerable<int> Take(IEnumerable<int> values, int amount)
        {
            return IterateElements(values, 0, amount);
        }

        static IEnumerable<int> IterateElements(IEnumerable<int> values, int index, int amount)
        {
            if(index < values.Count())
            {
                var result = IterateElements(values, index + 1, amount);

                if(index < amount)
                    return result.Prepend(values.ElementAt(index));

                return result;
            }

            return Enumerable.Empty<int>();
        }
    }
}
