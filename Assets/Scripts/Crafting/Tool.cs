using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tool : Craftable
{
    public Tool(string name, string description, Category parent, params Ingredient[] requirements) : base(name, description, parent, requirements)
    {
    }
}
