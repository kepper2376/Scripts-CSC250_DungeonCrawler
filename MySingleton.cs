using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton
{
    public static string currentDirection = "?";
    private static Room[] theRooms = new Room[100]; // static owned by the class - to access outside of the class with the name of the class

    private static int numRooms = 0;
    public static Room theCurrentRoom = null;

    public static void addRoom(Room r)
    {
        //static context
        MySingleton.theRooms[numRooms] = r;
        MySingleton.numRooms++;   
    }
}
