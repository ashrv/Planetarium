using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Resource : Component
{
    List<Item> products;
    Tool tool;

    public Resource(string name, string description, params Item[] products):base(name,description)
    {
        this.products = products.ToList();
    }

    public void Requires(Tool tool)
    {
        this.tool = tool;
    }

    public List<Item> Harvest(Tool tool)
    {
        if (this.tool.Equals(tool))
            return products;
        return null;
    }
}
