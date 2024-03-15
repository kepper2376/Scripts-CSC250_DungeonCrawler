using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   
    private string name;
    private Room currentRoom;

    public Player(string name)
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
        if(this.currentRoom != r)
        {
            this.currentRoom = r2;
        }
        else
        {
            this.currentRoom = r3;
        }
        else
        {
            this.currentRoom = r4;
        }
        else 
        {
            this.currentRoom = r5;
        }
        else 
        {
            this.currentRoom = r6;
        }
    }
}
