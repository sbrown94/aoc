using Library;
using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new Program().Run();
        }

        private void Run()
        {
            var lines = InputHelpers.GetAllLinesAsListString();

            foreach(var line in lines)
            {
                Console.WriteLine($"{ GetBoardingValue(line) }");
            }

        }

        private int GetBoardingValue(string line)
        {
            var range = 0;

            for(var i = 0; i < line.Length; i++)
            {
                if (line[i] == 'F')
                    range = range / 2;
                if (line[i] == 'B')
                    range = (range / 2) - (range / 4);
            }

            return range;
        }
    }
}
