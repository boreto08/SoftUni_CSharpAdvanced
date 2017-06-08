using System;
using System.Collections.Generic;
using System.Linq;
class ReverseNumbers
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();
        string[] nums = Console.ReadLine().Split(' ');

        foreach (var num in nums)
        {
            stack.Push(num);
        }

        while (stack.Count != 0 )
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}

