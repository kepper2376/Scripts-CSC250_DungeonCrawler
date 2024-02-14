using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;


public class Player1 : MonoBehaviour
{
    private float speed = 2.0f; 
    public GameObject destinationGO;   

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene("Scene2");
        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, this.destinationGO.transform.position, this.speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.gameObject.transform.position, this.destinationGO.transform.position) > 1.0)
        {
            this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, this.destinationGO.transform.position, this.speed * Time.deltaTime);
        }
    }
}
