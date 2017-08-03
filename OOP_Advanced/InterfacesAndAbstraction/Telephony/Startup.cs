
using System;

public class Startup
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split(' ');
        var sites = Console.ReadLine().Split(' ');

        Smartphone sf = new Smartphone();

        foreach (var num in nums)
        {
            Console.WriteLine(sf.Call(num)); 
        }
        foreach (var site in sites)
        {
            Console.WriteLine(sf.Browse(site));
        }


    }
}

