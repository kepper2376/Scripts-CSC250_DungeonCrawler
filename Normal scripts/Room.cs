using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
   // fields
    private string name;

    private Exit[] theExits = new Exit[4]; // collection of exits
    private int howManyExits = 0; // how many exits within the collection
    private Player currentPlayer;

    // constructor
    public Room(string name)
    {
        this.name = name;
        this.currentPlayer = null;
    }

    public void addPlayer(Player thePlayer)
    {
        this.currentPlayer = thePlayer;
        this.currentPlayer.setCurrentRoom(this);
    }

    public bool hasExit(string direction)
    {
        for(int i = 0; i < this.howManyExits; i++)
        {
            if(this.theExits[i].getDirection().Equals(direction))
            {
                return true;
            }
       }
       return false;
    }

    public void addExit(string direction, Room destinationRoom) // destinationRoom is a pointer and do not need * like in c++
    {
        if(this.howManyExits < this.theExits.Length) //  makes sure we do not go over 4 exits
        {
        Exit e = new Exit(direction, destinationRoom); // taking advantage of constructor in the Exit class
        this.theExits[this.howManyExits] = e;
        this.howManyExits++;
        }
    }
}
