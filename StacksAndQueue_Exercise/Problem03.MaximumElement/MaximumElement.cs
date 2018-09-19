using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumElement
{
    public static void Main()
    {
        Stack<int> nums = new Stack<int>();
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            int[] args = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            if (args.Length > 1 )
            {
                nums.Push(args[1]);
            }
            else if (args.Length == 1)
            {
                if (args[0] == 2)
                {
                    nums.Pop();
                }
                else if (args[0] == 3)
                {
                    Console.WriteLine(nums.Max());
                }
            }
            
        }
    }
}

