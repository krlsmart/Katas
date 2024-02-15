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
    }
}
