﻿
using System.Text;

public class Seat : ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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
        result.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}")
              .AppendLine(this.Start())
              .Append(this.Stop());

        return result.ToString();
    }
}

