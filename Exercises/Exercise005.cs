using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            return input.ToLower().Where(elements => Char.IsLetter(elements)).GroupBy(elements => elements).Count() == 26;
        }
    }
}
