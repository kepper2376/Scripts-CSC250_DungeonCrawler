using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton // place that can be shared to all - do not want to create a new dungeon everytime we create a new room
{
    public static string currentDirection = "?"; // static owned by the class - to access outside of the class with the name of the class
    public static Player thePlayer;
    public static Dungeon theDungeon = MySingleton.generateDungeon();
    public static int currentPellets = 10; //Set this back to ZERO for normal game play

    public static string flipDirection(string direction)
    {
        if(direction.Equals("north"))
        {
            return "south";
        }
        else if (direction.Equals("south"))
        {
            return "north";
        }
        else if (direction.Equals("east"))
        {
            return "west";
        }
        else if (direction.Equals("west"))
        {
            return "east";
        }
        else
        {
            Debug.Log(direction + " is not a legal direction in flipDirection inside of MySingleton");
            return "N/A";
        }
    }
    
    public static Dungeon generateDungeon()
    {
        Room r1 = new Room("R1"); // local variables
        Room r2 = new Room("R2");
        Room r3 = new Room("R3");
        Room r4 = new Room("R4");
        Room r5 = new Room("R5");
        Room r6 = new Room("R6");

        r1.addExit("north", r2);
        r2.addExit("south", r1);
        r2.addExit("north", r3);
        r3.addExit("south", r2);
        r3.addExit("west", r4);
        r3.addExit("north", r6);
        r3.addExit("east", r5);
        r4.addExit("east", r3);
        r5.addExit("west", r3);
        r6.addExit("south", r3);

        Dungeon theDungeon = new Dungeon("the cross");
        theDungeon.setStartRoom(r1); // technically dungeon only knows about 1 room, but this 1 room has mechanisms to connect to all the other rooms
        MySingleton.thePlayer = new Player("Mike");
        theDungeon.addPlayer(MySingleton.thePlayer);
        return theDungeon;    
    }    
}
