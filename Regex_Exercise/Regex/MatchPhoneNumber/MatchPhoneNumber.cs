
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main()
    {
        string patOne = @"\+359-2-[0-9]{3}-[0-9]{4}\b";
        string patTwo = @"\+359 2 [0-9]{3} [0-9]{4}\b";

        List<string> result = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            bool isMatchPatOne = Regex.IsMatch(input, patOne);
            bool isMatchPatTwo = Regex.IsMatch(input, patTwo);
            if (isMatchPatOne || isMatchPatTwo)
            {
                result.Add(input);
            }
        }

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

    }
}

