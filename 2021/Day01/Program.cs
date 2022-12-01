using Library;
using System;

namespace TwentyTwo.DayOne
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

            var answer = GetAnswer(lines);

            Console.WriteLine($"Answer: {answer}");
        }
    }
}
