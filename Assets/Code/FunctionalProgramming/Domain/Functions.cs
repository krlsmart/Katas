using FunctionalProgramming.Domain.CustomLinq;
using System;
using System.Collections.Generic;

namespace FunctionalProgramming.Domain
{
    public class Functions
    {
        //https://www.codewars.com/kata/563f879ecbb8fcab31000041
        public static Func<IEnumerable<int>, IEnumerable<int>> MultiplyBy(int multiplier)
            => array => array.CSelect(x => x * multiplier);
    }
}
