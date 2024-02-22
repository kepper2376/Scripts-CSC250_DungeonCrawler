using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonController : MonoBehaviour // is attached to gameObject so he needs to be a monobehavior
{
    // Start is called before the first frame update
    void Start()
    {
        // instance of Room
        Room r = new Room("a Room");
        MySingleton.addRoom(r);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
