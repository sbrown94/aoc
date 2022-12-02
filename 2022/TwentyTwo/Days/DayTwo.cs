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
                if (op == "A")
                    sc += 3;
                else if (op == "B")
                    sc += 1;
                else if (op == "C")
                    sc += 2;
            }
            else if (me == "Y")
            {
                if (op == "A")
                    sc += 4;
                else if (op == "B")
                    sc += 5;
                else if (op == "C")
                    sc += 6;
            }
            else if (me == "Z")
            {
                if (op == "A")
                    sc += 8;
                else if (op == "B")
                    sc += 9;
                else if (op == "C")
                    sc += 7;
            }

            return sc;
        }
    }
}
