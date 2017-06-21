using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string pattern = "\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
        List<string> matchedNames = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            bool isMatch = Regex.IsMatch(input,pattern);
            if (isMatch)
            {
                matchedNames.Add(input);
            }
        }

        Console.WriteLine(string.Join(" ",matchedNames));
    }
}

