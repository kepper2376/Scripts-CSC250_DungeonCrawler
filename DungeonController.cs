using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonController : MonoBehaviour
{
    public GameObject[] closedDoors;

    // Start is called before the first frame update
    private string mapIndexToStringForExit(int index)
    {
        if(index == 0)
        {
            return "north";
        }
        else if (index == 1)
        {
            return "south";
        }
        else if (index == 2)
        {
            return "east";
        }
        else if (index == 3)
        {
            return "west";
        }
        else
        {
            return "?";
        }
    }
    void Start()
    {
        if(MySingleton.createMap == false) // double equals bc comparing
         {
            MySingleton.createMap = true;
            MySingleton.createRooms();
         }

        this.MySingleton.theCurrentRoom = MySingleton.theRooms[MySingleton.playerPosition];

        int openDoorIndex = Random.Range(0, 4);
        this.closedDoors[openDoorIndex].SetActive(false); //visually make an open door
        MySingleton.theCurrentRoom.setOpenDoor(this.mapIndexToStringForExit(openDoorIndex));
        int[] Exits = new int[4];

        if(MySingleton.theRooms[MySingleton.playerPosition - 10] != null) // null checking to see if it doesn't exist
        {
            Exits[0] = 1;
        }

        if(MySingleton.theRooms[MySingleton.playerPosition + 10] != null) // null checking to see if it doesn't exist
        {
            Exits[1] = 2;
        }

        if(MySingleton.theRooms[MySingleton.playerPosition - 1] != null) // null checking to see if it doesn't exist
        {
            Exits[2] = 3;
        }

        if(MySingleton.theRooms[MySingleton.playerPosition + 1] != null) // null checking to see if it doesn't exist
        {
            Exits[3] = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}