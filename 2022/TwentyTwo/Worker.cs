using Library;
using System;
using System.Collections.Generic;
using TwentyTwo.Days;

namespace TwentyTwo
{
    public class Worker : IWorker
    {
        private readonly IDay _day;

        public Worker(IDay day)
        {
            _day = day ?? throw new ArgumentNullException(nameof(day));
        }

        public void Run()
        {
            var data = GetData(_day.FilePath);
            var answer = _day.Calculate(data?.ToArray());

            Print(answer);
        }

        public List<string> GetData(string path) => InputHelpers.GetAllLinesAsListString(path);

        public void Print(string answer)
        {
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
