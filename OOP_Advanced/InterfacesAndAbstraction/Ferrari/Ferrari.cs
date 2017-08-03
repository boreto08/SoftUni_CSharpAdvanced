
using System;

public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Model { get;  private set; }

    public string Driver { get; private set; }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public string Stop()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Stop()}/{this.Gas()}/{this.Driver}";
    }
}

