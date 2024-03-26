using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class inhabitant // 
{
    protected string name;
    protected Room currentRoom;
    public inhabitant(string name)
    {
        this.name = name;
        this.currentRoom = null;
    }
    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }

    public void setCurrentRoom(Room r)
    {
        this.currentRoom = r;
    }
}
