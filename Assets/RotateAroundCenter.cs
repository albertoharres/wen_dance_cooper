using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateAroundCenter : MonoBehaviour {

   // GameObject[] characters;

    private List<GameObject> characters = new List<GameObject>();

    // public List<GameObject> characters;

    public float velocity = 10f; 
    public float radius = 30f;

    
    // Use this for initialization
    void Start () {

        var container = GameObject.Find("characters");

        var children = container.GetComponentsInChildren<Transform>();
       // characters = GameObject.FindGameObjectsWithTag("wen");
      
        foreach (var child in children)
        {
            if (child.tag == "wen")
            {
                characters.Add(child.gameObject);
            }
        }

        float stepAngle = 0;
        float theta = 0;

        foreach (GameObject obj in characters)
        {
            stepAngle += Mathf.PI * 2f / characters.Count;
            theta = 360 - 180 * (stepAngle / Mathf.PI);
            obj.transform.Rotate(Vector3.up, theta);
        }
    }
	
	// Update is called once per frame
	void Update () {
        float stepAngle = 0;

        foreach (GameObject obj in characters)
        {
            stepAngle += Mathf.PI * 2f / characters.Count;

            float x = Mathf.Cos(Time.realtimeSinceStartup / 1000 + stepAngle) * radius;
            float z = Mathf.Sin(Time.realtimeSinceStartup / 1000 + stepAngle) * radius;
            obj.transform.localPosition = new Vector3(x, 0, z);

        }
        transform.rotation = Quaternion.AngleAxis(velocity * Time.realtimeSinceStartup, Vector3.up);
    }
}
