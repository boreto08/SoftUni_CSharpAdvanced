
using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }

    public int Battery { get; private set; }

    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = batteries;
    }

    public string Start()
    {
        return "Engine start!";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine($"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries")
              .AppendLine(this.Start())
              .Append(this.Stop());

        return result.ToString();
    }
}

