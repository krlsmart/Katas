using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/563f879ecbb8fcab31000041
namespace FunctionalProgramming.Domain
{
    public class FirstClass
    {
        public static Func<IEnumerable<int>, IEnumerable<int>> Factory(int multiplier)
            => array => array.Select(x => x * multiplier);
    }
}
