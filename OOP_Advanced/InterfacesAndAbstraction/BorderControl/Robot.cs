﻿
public class Robot : ICitizen
{
    public Robot(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public string Name { get; private set; }

    public string Id { get; private set; }
}
