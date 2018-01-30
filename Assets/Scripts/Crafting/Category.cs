using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Category : Component
{
    public Category(string name, string description) : base(name, description)
    {
    }

    public List<Craftable> children { get; private set; }

    public int Count()
    {
        return children.Count;
    }

}
