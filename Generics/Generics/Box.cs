
using System;
using System.Collections;
using System.Collections.Generic;

public class Box<T> : ICountable 
{
    private Stack<T> collention;

    public Box()
    {
        this.collention = new Stack<T>();
    }

    public int Count
    {
        get
        {
            return this.collention.Count;
        }
    }

    public void Add(T element)
    {
        collention.Push(element);
    }

    public T Remove()
    {
       return collention.Pop();
    }
}

