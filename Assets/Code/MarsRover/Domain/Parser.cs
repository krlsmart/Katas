using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Domain
{
    public static class Parser
    {
        public static IEnumerable<string> Split(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new System.ArgumentException("Invalid input");

            return input.Select(s => s.ToString());
        }
    }
}
