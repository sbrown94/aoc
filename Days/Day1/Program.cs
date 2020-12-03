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

            var answer = GetThreeAnswerCombo(lines);

            Console.WriteLine($"Answer: {answer}");
        }

        private int GetThreeAnswerCombo(List<int> lines)
        {
            for (var i = 0; i < lines.Count; i++)
            {
                for (var j = 0; j < lines.Count; j++)
                {
                    for (var k = 0; k < lines.Count; k++)
                    {
                        if (i == j || i == k || j == k) continue;

                        if (lines[i] + lines[j] + lines[k] == 2020)
                            return lines[i] * lines[j] * lines[k];
                    }
                }
            }

            throw new InvalidOperationException("Combination not found in list");
        }

        private int GetTwoAnswerCombo(List<int> lines)
        {
            for (var i = 0; i < lines.Count; i++)
            {
                for (var j = 0; j < lines.Count; j++)
                {
                    if (i == j) continue;

                    if (lines[i] + lines[j] == 2020)
                        return lines[i] * lines[j];
                }
            }

            throw new InvalidOperationException("Combination not found in list");
        }
    }
}
