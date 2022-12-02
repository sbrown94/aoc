using System.Collections.Generic;

namespace TwentyTwo
{
    public interface IWorker
    {
        public void Run();

        public List<string> GetData(string path);

        public void Print(string answer);
    }
}
