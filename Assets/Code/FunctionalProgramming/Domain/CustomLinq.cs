using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain.CustomLinq
{
    public static class CustomLinq
    {
        public static IEnumerable<int> CTake(this IEnumerable<int> values, int amount)
            => values.IterateElements((index) => index < amount);

        //https://www.codewars.com/kata/the-takewhile-function
        public static IEnumerable<int> CTakeWhile(this IEnumerable<int> values, Func<int, bool> predicate)
            => values.IterateWhileCondition(predicate, Enumerable.Empty<int>());

        #region Aux Methods
        static IEnumerable<int> IterateElements(this IEnumerable<int> values, Func<int, bool> condition, int index = 0)
        {
            if (index < values.Count())
            {
                var result = IterateElements(values, condition, index + 1);

                return condition(index)
                    ? new int[] { values.ElementAt(index) }.Concat(result)
                    : result;
            }

            return Enumerable.Empty<int>();
        }

        static IEnumerable<int> IterateWhileCondition(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0) 
            => index < values.Count() && predicate(values.ElementAt(index))
                ? values.IterateWhileCondition(predicate, result.Append(values.ElementAt(index)), index + 1)
                : result;

        #endregion
    }
}