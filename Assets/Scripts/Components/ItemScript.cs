using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ItemScript:MonoBehaviour
{
    Ingredient content;
    public Item item
    {
        get
        {
            return content.item;
        }
    }
    public int count
    {
        get
        {
            return content.count;
        }
    }

    internal void Add(Item item = null)
    {
        if (item != null)
            content = new Ingredient(item);
        else if (content != null)
            content.Add();
    }

    internal void Remove(int count)
    {
        if (content != null)
            content.Remove(count);
    }
}

