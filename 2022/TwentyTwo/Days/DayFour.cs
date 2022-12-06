using System;

namespace TwentyTwo.Days
{
    internal class DayFour : IDay
    {
        public string FilePath { get => "Input/day4.txt"; }

        public string Calculate(string[] input)
        {
            var rangesContainOther = 0;

            foreach(var line in input)
            {
                var items = line.Split(',');

                var item1 = SplitItem(items[0]);
                var item2 = SplitItem(items[1]);

                if (item1.a >= item2.a && item1.b <= item2.b
                    || item2.a >= item1.a && item2.b <= item1.b)
                    rangesContainOther++;
            }

            return rangesContainOther.ToString();
        }

        private (int a, int b) SplitItem(string item)
        {
            var spl = item.Split('-');
            return (Int32.Parse(spl[0]), Int32.Parse(spl[1]));
        }
    }
}
