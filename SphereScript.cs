using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Inside Sphere Script");
        print("Secret Number = " + MySingleton.secretNumber);

    }

    void Update()
    {
        
    }
}
