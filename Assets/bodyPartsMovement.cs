using UnityEngine;
using System.Collections;

public class bodyPartsMovement : MonoBehaviour {

    GameObject[] head;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        head = GameObject.FindGameObjectsWithTag("head");

        foreach(GameObject obj in head)
        {
        }
    }
}
