using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Library
{
    public class InputHelpers
    {
        public const string DefaultFilePath = @"input.txt";

        public static List<string> GetAllLinesAsListString(string filePath = DefaultFilePath)
        {
            return File.ReadAllLines(filePath)?.ToList();
        }

        public static List<int> GetAllLinesAsListInt(string filePath = DefaultFilePath)
        {
            return GetAllLinesAsListString(filePath)?.Select(Int32.Parse).ToList();
        }
    }
}
