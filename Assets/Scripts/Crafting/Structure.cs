using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Structure : Craftable
{
    Function function;
    public Structure(string name, string description, Structure parent,params Ingredient[] requirements)
        : base(name, description, parent, requirements)
    {
    }

    public Structure(string name, string description, Category parent, params Ingredient[] requirements)
        : base(name, description, parent,requirements)
    {
    }

    internal void Function(float duration, Action action, params Item[] activators)
    {
        function = new Function(duration, action, activators.ToList());
    }
}
