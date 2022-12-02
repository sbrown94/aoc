using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyTwo.Days
{
    internal class DayTwo : IDay
    {
        public string FilePath { get => "Input/day2.txt"; }

        public string Calculate(string[] input)
        {
            var tot = 0;

            foreach(var line in input)
            {
                var s = line.Split(' ');
                tot += CalculateScore(s[0], s[1]);
            }

            return tot.ToString();
        }

        private int CalculateScore(string op, string me)
        {
            var sc = 0;

            if (me == "X")
            {
                sc += 1;

                if (op == "A")
                    sc += 3;
                else if (op == "C")
                    sc += 6;
            }
            else if (me == "Y")
            {
                sc += 2;

                if (op == "B")
                    sc += 3;
                else if (op == "A")
                    sc += 6;
            }
            else if (me == "Z")
            {
                sc += 3;

                if (op == "C")
                    sc += 3;
                else if (op == "B")
                    sc += 6;
            }

            return sc;
        }
    }
}
