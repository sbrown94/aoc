﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyTwo.Days
{
    internal class DayOne : IDay
    {
        public string FilePath { get => "Input/day1.txt"; }

        public string Calculate(string[] input)
        {
            var elves = new List<int>();

            var calories = 0;

            foreach(var i in input)
            {
                if (i != "")
                    calories += Int32.Parse(i);
                else
                {
                    elves.Add(calories);
                    calories = 0;
                }
            }

            return elves.Max().ToString();
        }
    }
}
