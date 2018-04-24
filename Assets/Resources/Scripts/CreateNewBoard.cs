using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBoard : MonoBehaviour {

    public Rigidbody board;

    // Use this for public GameObject prefab;
    public GameObject prefab;
    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = .001f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnPress()
    {
        for (float y = 0; y < gridY; y += spacing)
        {
            Debug.Log("This is y: " + y);
            for (float x = 0; x < gridX; x += spacing)
            {
                Debug.Log("This is x: " + x);
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
        Debug.Log("Complete Spawn");
    }
}
