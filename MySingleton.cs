using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton // removed monobehaviro removes start and update
{
    static public int secretNumber = -1; // static owned by the class - to access outside of the class with the name of the class
}
