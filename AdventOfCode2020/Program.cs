using System;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            var lines = InputHelpers.GetAllLinesAsListInt();

            var combination = GetAnswerCombo(lines);

            Console.WriteLine($"First Number: {combination.firstNo} | Second Number: {combination.secondNo}");

            var answer = combination.firstNo * combination.secondNo;

            Console.WriteLine($"Answer: {answer}");
        }

        private (int firstNo, int secondNo) GetAnswerCombo(List<int> lines)
        {
            for (var i = 0; i < lines.Count; i++)
            {
                for (var j = 0; j < lines.Count; j++)
                {
                    if (i == j) continue;

                    if (lines[i] + lines[j] == 2020)
                        return (lines[i], lines[j]);
                }
            }

            throw new InvalidOperationException("Combination not found in list");
        }
    }
}
