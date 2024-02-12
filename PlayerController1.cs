using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // uses TMPro namespace/library

public class playerController1 : MonoBehaviour
{
    private Player thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
       // Vector3.MoveTowards - static method bc we are calling it with class - use this with time delta time to complete HW
        this.thePlayer = new Player("Mike");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
        /* this.tm.transform.position = new Vector3(this.gameObject.transform.position.x, 
                                                this.gameObject.transform.position.y + 1, 
                                                this.gameObject.transform.position.z);
                                                */
                                                // puts text mesh where you want it
        this.gameObject.transform.position = this.destinationGO.transform.position; // set Vector3 to the same
    }

    private void Update()
    {
        if(Vector3.Distance(this.gameObject.transform.position, this.destinationGO.transform.position) > 1.0f)
        {
        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, this.destinationGO.transform.position, this.speed * Time.deltaTime);
    // static funtion so you call with class name "Vector3"
    // Slerp vs Lerp behaviors to see which ones look cool
        }

        // this.thePlayer.display();
        // playerName.text = this.thePlayer.getName(); 
        // playerName.text = this.thePlayer.gethp();         
        /*
        if(mySingleton.player1Turn == true) //  if player 1 turn
        {
           print("Player 1: " + mySingleton.count);
           mySingleton.count++;
           mySingleton.player1Turn = false; 
        }  
        */
    }
}
