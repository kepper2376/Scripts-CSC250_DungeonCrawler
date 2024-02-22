using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room // not a monobehavior so not update or start
{
    // field
    private string name;

    // constructor
    public Room(string name)
    {
        this.name = name;
    }
}
