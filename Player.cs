using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Secret Number = " + MySingleton.secretNumber);
        MySingleton.secretNumber = 5;
        EditorSceneManager.LoadScene("Scene2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
