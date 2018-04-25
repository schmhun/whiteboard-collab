using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoardOnStartup : MonoBehaviour {

    // Use this for public GameObject prefab;
    public GameObject prefab;

    public GameObject boardParent;

    public float buffX = 0f;
    public float buffY = 1f;
    public float buffZ = 1f;

    public float gridX = 50f;
    public float gridY = 50f;

    public float spacing = .02f;

    void Start()
    {
        Vector3 start = new Vector3(0,0,0);
        //boardParent = Instantiate(boardParent, start, Quaternion.identity);

        for (float y = 0; y < gridY; y+=1f)
        {
            //Debug.Log("This is y: " + y);
            for (float x = 0; x < gridX; x+=1f)
            {
                //Debug.Log("This is x: " + x);
                Vector3 pos = new Vector3(x+buffX, y+buffY, 0) * spacing;
                //Instantiate(prefab, pos, Quaternion.identity, boardParent.transform);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
        Debug.Log("Complete Startup");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
