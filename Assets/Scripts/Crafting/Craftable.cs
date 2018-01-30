using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Craftable : Component
{
    List<Ingredient> requirements;
    public List<Craftable> children { get; private set; }
    public Category category { get; private set; }
    public bool disabled { get; set; }
    public bool hidden { get; set; }

    public Craftable(string name, string description,Craftable parent, Ingredient[] requirements):base(name,description)
    {
        parent.children.Add(this);
        this.requirements = requirements.ToList();
    }

    public Craftable(string name, string description, Category parent, Ingredient[] requirements) : base(name, description)
    {
        this.category = category;
        this.requirements = requirements.ToList();
    }
    
    public int Count()
    {
        return children.Count;
    }
}
