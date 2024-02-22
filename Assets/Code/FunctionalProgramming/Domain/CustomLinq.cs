using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain.CustomLinq
{
    public static class CustomLinq
    {
        public static IEnumerable<int> CTake(this IEnumerable<int> values, int amount)
            => values.TakeIndexWhile((index) => index < amount, Enumerable.Empty<int>());

        //https://www.codewars.com/kata/the-takewhile-function
        public static IEnumerable<int> CTakeWhile(this IEnumerable<int> values, Func<int, bool> predicate)
            => values.TakeElementWhile(predicate, Enumerable.Empty<int>());

        //https://www.codewars.com/kata/the-dropwhile-function
        public static IEnumerable<int> CDropWhile(this IEnumerable<int> values, Func<int, bool> predicate)
            => values.DropElementWhile(predicate, Enumerable.Empty<int>());

        //https://www.codewars.com/kata/the-span-function
        public static (IEnumerable<int> first, IEnumerable<int> last) CSpan(this IEnumerable<int> values, Func<int, bool> predicate)
            => (values.CTakeWhile(predicate), values.CDropWhile(predicate));


        #region Aux Methods
        static IEnumerable<int> TakeIndexWhile(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0)
            => index < values.Count() && predicate(index)
                ? values.TakeIndexWhile(predicate, result.Append(values.ElementAt(index)), index + 1)
                : result;

        static IEnumerable<int> TakeElementWhile(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0) 
            => index < values.Count() && predicate(values.ElementAt(index))
                ? values.TakeElementWhile(predicate, result.Append(values.ElementAt(index)), index + 1)
                : result;

        static IEnumerable<int> DropElementWhile(this IEnumerable<int> values, Func<int, bool> predicate, IEnumerable<int> result, int index = 0)
            => index < values.Count() && predicate(values.ElementAt(index))
                ? values.DropElementWhile(predicate, result, index + 1)
                : values.TakeIndexWhile(i => i < values.Count(), result, index);
        #endregion
    }
}