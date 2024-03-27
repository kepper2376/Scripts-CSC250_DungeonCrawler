using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class inhabitant // 
{
    protected string name;
    protected Room currentRoom;
    protected int hp;
    public inhabitant(string name)
    {
        this.name = name;
        this.currentRoom = null;
        this.hp = 100;
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
