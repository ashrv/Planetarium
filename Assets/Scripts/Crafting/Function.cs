using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Function
{
    public List<Item> requirements { get; private set; }
    public float duration { get; private set; }
    public Action action { get;private set; }
    
    public Function() { }
    public Function(float duration, Action action, List<Item> requirements=null)
    {
        this.duration = duration;
        this.action = action;
        this.requirements = requirements;
      
    }

}
