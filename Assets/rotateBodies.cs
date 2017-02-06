using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rotateBodies : MonoBehaviour
{
    private List<GameObject> characters = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 10);

        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[]; //will return an array of all GameObjects in the scene
        foreach (GameObject go in gos)
        {
            if (go.layer.Equals("Cube"))
            {
                //do something
                go.transform.Rotate(Vector3.up * Time.deltaTime * 10);

            }
        }

    }
}
