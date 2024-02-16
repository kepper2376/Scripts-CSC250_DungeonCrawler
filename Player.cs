using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;


public class Player : MonoBehaviour
{
    private float speed = 2.0f; // f at the end bc its a float rather than a double
    // double can hold bigger values with more precision compared to floats
    public GameObject northExit;  
    public GameObject southExit; 
    public GameObject eastExit; 
    public GameObject westExit; 
    

    // Start is called before the first frame update
    void Start()
    {
       // if not equal to 
       // if not our first scene
       if(!MySingleton.currentDirection.Equals("?")) // checks to see the contents of the string the same rather than == would be for pointers to be the same
       {
            if(MySingleton.currentDirection.Equals("North"))
            {
                this.gameObject.transform.position = this.southExit.transform.position;
            }
       }
    }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Door"))
            {
            MySingleton.currentDirection = "North";
            EditorSceneManager.LoadScene("DungeonRoom");
            }             
         }

    // Update is called once per frame
    void Update()
    {
       // MoveTowards wants us to give it (current location, destination we want it to go to, )
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.northExit.transform.position, this.speed * Time.deltaTime);
    }
}
