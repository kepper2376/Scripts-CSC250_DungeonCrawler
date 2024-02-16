using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton // removed monobehavior removes start and update
{
     // static owned by the class - to access outside of the class with the name of the class
    public static string currentDirection = "?";
}
