using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain.CustomLinq
{
    public static class CustomLinq
    {
        public static IEnumerable<int> CTake(this IEnumerable<int> values, int amount)
            => values.IterateConditionOnIndex((index) => index < amount, Enumerable.Empty<int>());

        //https://www.codewars.com/kata/the-takewhile-function
        public static IEnumerable<int> CTakeWhile(this IEnumerable<int> values, Func<int, bool> predicate)
            => values.IterateConditionOnValue(predicate, Enumerable.Empty<int>());


        #region Aux Methods
        static IEnumerable<int> IterateConditionOnIndex(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0)
            => index < values.Count() && predicate(index)
                ? values.IterateConditionOnIndex(predicate, result.Append(values.ElementAt(index)), index + 1)
                : result;

        static IEnumerable<int> IterateConditionOnValue(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0) 
            => index < values.Count() && predicate(values.ElementAt(index))
                ? values.IterateConditionOnValue(predicate, result.Append(values.ElementAt(index)), index + 1)
                : result;
        #endregion
    }
}