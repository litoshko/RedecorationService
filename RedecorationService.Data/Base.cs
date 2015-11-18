using System;
using System.Collections.Generic;

public class Base<T> where T : Base<T>
{
    public Guid Id;
    public static List<T> Items = new List<T>();

    public Base()
    {
        Id = Guid.NewGuid();
        Items.Add((T)this);
    }
}
