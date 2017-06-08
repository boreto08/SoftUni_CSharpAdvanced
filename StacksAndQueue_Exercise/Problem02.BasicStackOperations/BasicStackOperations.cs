using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main()
    {
        int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int countNums = tokens[0];
        int timesToPop = tokens[1];
        int numToCheck = tokens[2];

        int[] numsToEnter = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Stack<int> stackNums = new Stack<int>();

        for (int i = 0; i < countNums; i++)
        {
            stackNums.Push(numsToEnter[i]);
        }

        for (int i = 0; i < timesToPop; i++)
        {
            stackNums.Pop();
        }
        bool hasFound = false;

        int smallestNum = int.MaxValue;

        while (stackNums.Count != 0)
        {
            int currNum = stackNums.Pop();

            if (currNum == numToCheck)
            {
                Console.WriteLine("true");
                hasFound = true;
                break;
            }
            else
            {
                if (currNum < smallestNum)
                {
                    smallestNum = currNum;
                }
            }
        }

        if (!hasFound)
        {
            Console.WriteLine(smallestNum);
        }

    }
}

