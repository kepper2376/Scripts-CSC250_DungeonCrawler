using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    private string name;
    private Room currentRoom; // player becomes aware of current room

    public Player(string name)
    {
        this.name = name;
        this.currentRoom = null;
    }

    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }
}
