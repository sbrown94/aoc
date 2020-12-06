using System;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private static string[] RequiredFields = {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};

        private void Run()
        {
            var data = InputHelpers.GetAllLinesAsKeyValueList();

            var validPassports = 0;

            foreach(var passport in data)
            {
                if (CheckPassport(passport))
                    validPassports++;
            }

            Console.WriteLine($"Valid passports: {validPassports}");
        }

        private bool CheckPassport(Dictionary<string,string> passport)
        {
            foreach(var field in RequiredFields)
            {
                if (!passport.ContainsKey(field))
                    return false;

                var value = passport.GetValueOrDefault(field);

                switch(field)
                {
                    case "byr":
                        {
                            var year = Int32.Parse(value);
                            if (year < 1920 || year > 2002)
                                return false;
                            break;
                        }
                    case "iyr":
                        {
                            var year = Int32.Parse(value);
                            if (year < 2010 || year > 2020)
                                return false;
                            break;
                        }
                    case "eyr":
                        {
                            var year = Int32.Parse(value);
                            if (year < 2020 || year > 2030)
                                return false;
                            break;
                        }
                    case "hgt":
                        {
                            var suffix = value.Substring(value.Length - 2);

                            if (suffix != "cm" && suffix != "in")
                                return false;

                            if (!Int32.TryParse(value.Substring(0, 3), out var height))
                                height = Int32.Parse(value.Substring(0, 2));

                            if (suffix == "cm" && (height < 150 || height > 193))
                                return false;
                            
                            if (suffix == "in" && (height < 59 || height > 76))
                                return false;

                            break;
                        }
                    case "hcl":
                        {
                            if (value.Substring(0, 1) != "#")
                                return false;

                            var colour = value.Substring(1, value.Length - 1);

                            if (!Int32.TryParse(colour, out var res))
                            {
                                var acceptedLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
                                if (colour.ToArray().Except(acceptedLetters).Any())
                                    return false; 
                            }
                            break;
                        }
                    case "ecl":
                        {
                            var validEyeColours = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

                            if (!validEyeColours.Any(x => x == value))
                                return false;

                            break;
                        }
                    case "pid":
                        {
                            if (value.Length != 9)
                                return false;

                            break;
                        }
                }
            }

            return true;
        }
    }
}
