using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyTwo.Days
{
    internal class DayThree : IDay
    {
        public string FilePath { get => "Input/day3.txt"; }

    public string Calculate(string[] input)
        {
            var total = 0;

            for (var i = 0; i < input.Length; i += 3)
            {
                char val = '0';

                foreach(var ch in input[i])
                {
                    if (input[i+1].Contains(ch) && input[i+2].Contains(ch))
                    {
                        val = ch;
                    }
                }

                var res = (int)val % 32;
                if (Char.IsUpper(val))
                    res += 26;

                total += res;
            }

            return total.ToString();
        }
    }
}
