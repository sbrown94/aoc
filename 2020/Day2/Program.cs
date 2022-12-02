using Library;
using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            var lines = InputHelpers.GetAllLinesAsListString();

            var answer = 0;

            foreach(var line in lines)
            {
                string[] range;
                string letter, pw;
                (range, letter, pw) = GetInput(line);

                if (CheckValidPart2(range, letter, pw))
                    answer++;
            }


            Console.WriteLine($"Answer: {answer}");
        }

        private bool CheckValidPart2(string[] range, string letter, string pw)
        {
            var ok = false;

            var firstIndex = Int32.Parse(range[0]);
            var secondIndex = Int32.Parse(range[1]);

            for (var i = 0; i < pw.Length; i++)
            {
                if (i+1 != firstIndex && i+1 != secondIndex)
                    continue;

                if (pw[i] == char.Parse(letter))
                    if (!ok)
                        ok = true;
                    else
                        ok = false;
            }

            return ok;
        }

        private bool CheckValidPart1(string[] range, string letter, string pw)
        {
            var lowerBound = Int32.Parse(range[0]);
            var upperBound = Int32.Parse(range[1]);

            var count = 0;

            foreach(var c in pw)
            {
                if (c == char.Parse(letter))
                    count++;
            }

            if (count >= lowerBound && count <= upperBound)
                return true;

            return false;
        }

        private (string[], string, string) GetInput(string line)
        {
            var split = line.Split(": ");
            var policy = split[0];
            var pw = split[1];
            var policySplit = policy.Split(" ");
            var numRange = policySplit[0];
            var range = numRange.Split("-");
            var letter = policySplit[1];

            return (range, letter, pw);
        }


    }
}
