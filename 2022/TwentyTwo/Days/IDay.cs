﻿namespace TwentyTwo.Days
{
    public interface IDay
    {
        public string FilePath { get; }
        public string Calculate(string[] input);
    }
}
