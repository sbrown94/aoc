using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace TwentyThree.Days
{
    internal class DayOne : IDay
    {
        public string FilePath { get => "Input/day1.txt"; }

        public class ValStore
        {
            public int firstIndex { get; set; } = 9999;
            public string firstValue { get; set; } = "";
            public int lastIndex { get; set; } = -1;
            public string lastValue { get; set; } = "";
        }

        public string Calculate(string[] input)
        {
            long runningTotal = 0;

            Dictionary<string, string> numberMap = new Dictionary<string, string>()
            {
                {"one", "1"},
                {"two", "2"},
                {"three", "3"},
                {"four", "4"},
                {"five", "5"},
                {"six", "6"},
                {"seven", "7"},
                {"eight", "8"},
                {"nine", "9"}
            };
            
            foreach (var line in input)
            {
                var valStore = new ValStore();
                
                foreach (var num in numberMap)
                {
                    var firstIndex = line.IndexOf(num.Key);

                    if (firstIndex != -1 && firstIndex < valStore.firstIndex)
                    {
                        valStore.firstIndex = firstIndex;
                        valStore.firstValue = num.Value;
                    }

                    firstIndex = line.IndexOf(num.Value);

                    if (firstIndex != -1 && firstIndex < valStore.firstIndex)
                    {
                        valStore.firstIndex = firstIndex;
                        valStore.firstValue = num.Value;
                    }

                    var lastIndex = line.LastIndexOf(num.Key);

                    if (lastIndex != -1 && lastIndex > valStore.lastIndex)
                    {
                        valStore.lastIndex = lastIndex;
                        valStore.lastValue = num.Value;
                    }

                    lastIndex = line.LastIndexOf(num.Value);

                    if (lastIndex != -1 && lastIndex > valStore.lastIndex)
                    {
                        valStore.lastIndex = lastIndex;
                        valStore.lastValue = num.Value;
                    }
                    
                }
                
                Console.WriteLine($"Line: {line}");
                Console.WriteLine($"Calculated value: {valStore.firstValue}{valStore.lastValue}");

                runningTotal += (long.Parse($"{valStore.firstValue}{valStore.lastValue}"));
                
                Console.WriteLine($"New total: {runningTotal}");
            }
            
            return runningTotal.ToString();
        }
    }
}