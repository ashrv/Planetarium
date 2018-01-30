using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Slot:MonoBehaviour
{
    [SerializeField]GameObject holderPrefab;

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
    public bool empty
    {
        get
        {
            return content == null;
        }
    }

    private void OnValidate()
    {
        holderPrefab = Assets.prefabs.Get("Slot");
    }

    public void Add(Item item)
    {
        if (empty)
        {
            content = new Ingredient(item);
        }
        else if(item.Equals(item))
        {
            content.Add();
        }
    }
}
