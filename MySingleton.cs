using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton
{
    public static string currentDirection = "?";
    public static Room[] theRooms = new Room[100]; // static owned by the class - to access outside of the class with the name of the class

    private static int numRooms = 0;
    public static Room theCurrentRoom = null;

    public bool createMap = false;

    public int playerPosition = 0;

    public void createRooms()
    {
        for(int i = 0; i < 100; i++)
        {
            if(Random.Range(0,2) == 1)
            {
                theRooms[i] = new Room(i.ToString());
            }
        }
    }

    public static void addRoom(Room r)
    {
        //static context
        MySingleton.theRooms[numRooms] = r;
        MySingleton.numRooms++;   
    }
}
