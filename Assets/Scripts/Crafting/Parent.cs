using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface Parent
{
    int Count();
    List<Craftable> children { get; }
}
