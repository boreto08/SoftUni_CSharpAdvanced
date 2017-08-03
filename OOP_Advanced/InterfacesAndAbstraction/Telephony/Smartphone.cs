
using System;
using System.Collections.Generic;

public class Smartphone : Browseable, Callable
{
    public Smartphone()
    {

    }


    public string Browse(string site)
    {

        if (isDigitFree(site))
        {
            return $"Browsing: {site}!";
        }
        return "Invalid URL!";


    }

    public string Call(string number)
    {

        if (isOnlyDigits(number))
        {
            return $"Calling... {number}";
        }

        return "Invalid number!";

    }

    public bool isDigitFree(string site)
    {
        foreach (var ch in site)
        {
            if (Char.IsDigit(ch))
            {
                return false;
            }
        }

        return true;
    }

    public bool isOnlyDigits(string num)
    {
        foreach (var ch in num)
        {
            if (!Char.IsDigit(ch))
            {
                return false;
            }
        }

        return true;
    }
}

