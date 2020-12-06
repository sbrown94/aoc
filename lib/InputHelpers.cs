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

        public static List<Dictionary<string,string>> GetAllLinesAsKeyValueList(string filePath = DefaultFilePath)
        {
            var output = new List<Dictionary<string, string>>();
            
            var lines = GetAllLinesAsListString(filePath);

            var dict = new Dictionary<string, string>();

            lines.Add("");

            foreach(var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    output.Add(dict);
                    dict = new Dictionary<string, string>();
                    continue;
                }

                var items = line.Split(' ');

                foreach(var item in items)
                {
                    var keyValue = item.Split(':');

                    dict.Add(keyValue[0], keyValue[1]);
                }
            }

            return output;
        }
    }
}
