using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Ingredient
{
    public Item item { get; private set; }
    public int count { get; private set; }

    public Ingredient(Item item, int count=0)
    {
        this.item = item;
        this.count = count;
    }

    internal void Add()
    {
        count++;
    }

    internal void Remove(int count)
    {
        this.count -= count;
    }
}
