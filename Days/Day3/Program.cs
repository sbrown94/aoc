using System;
using System.Collections.Generic;
using System.Drawing;
using Library;

namespace ConsoleApp1
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

            var routes = new List<Point>()
            {
                new Point(1,1),
                new Point(3,1),
                new Point(5,1),
                new Point(7,1),
                new Point(1,2)
            };

            long answer = 1;

            foreach(var route in routes)
            {
                var t= GoDownSlope(lines, route.X, route.Y);
                answer *= GoDownSlope(lines, route.X, route.Y);
            }

            Console.WriteLine($"Answer: {answer}");
        }

        private int GoDownSlope(List<string> lines, int addX, int addY)
        {
            var encounteredTrees = 0;

            var currentPosX = 0;

            for (var i = addY; i < lines.Count; i+=addY)
            {
                currentPosX += addX;
                if (currentPosX >= lines[i].Length)
                    currentPosX = currentPosX - lines[i].Length;

                if (lines[i][currentPosX] == '#')
                    encounteredTrees++;
            }

            return encounteredTrees;
        }

    }
}
