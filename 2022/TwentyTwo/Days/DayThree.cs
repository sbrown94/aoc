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

            foreach(var line in input)
            {
                var bp1 = line.Substring(0, line.Length/2)?.ToCharArray();
                var bp2 = line.Substring(line.Length/2)?.ToCharArray();

                var dups = new List<char>();

                foreach(var let in bp2)
                {
                    if (bp1.Contains(let) && !dups.Contains(let))
                        dups.Add(let);
                }

                var res = 0;

                foreach (var dup in dups)
                {
                    res += (int)dup % 32;
                    if (Char.IsUpper(dup))
                        res += 26;
                }

                total += res;
            }

            return total.ToString();
        }
    }
}
