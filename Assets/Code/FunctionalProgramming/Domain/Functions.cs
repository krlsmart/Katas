using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming.Domain
{
    public class Functions
    {
        //https://www.codewars.com/kata/563f879ecbb8fcab31000041
        public static Func<IEnumerable<int>, IEnumerable<int>> MultiplyBy(int multiplier)
            => array => array.Select(x => x * multiplier);

        //https://www.codewars.com/kata/the-takewhile-function
        //public static Func<IEnumerable<int>> TakeWhile(IEnumerable<int> values, Func<bool> predicate)

        //https://www.codewars.com/kata/the-dropwhile-function
        //public static Func<IEnumerable<int>> DropWhile(IEnumerable<int> values, Func<bool> predicate)

        //https://www.codewars.com/kata/the-span-function
        //public static Func<IEnumerable<int>> Span(IEnumerable<int> values, Func<bool> predicate)
    }
}
