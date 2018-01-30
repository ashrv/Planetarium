using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Player : MonoBehaviour
{
    internal Item held { get; private set; }

    internal Tool equipped { get; private set; }
}
