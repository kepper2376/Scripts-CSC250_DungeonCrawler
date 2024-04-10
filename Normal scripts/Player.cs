using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : inhabitant
{
    private Room currentRoom;

    public Player(string name) : base(name)
    {
    }

    public void resetStats()
    {
        this.hp = this.maxHP;
    }
}
