using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseOnBoard : MonoBehaviour {
    private GameObject thumbLeft;
    private GameObject thumbRight;
    private GameObject thumbPrefer;
    private GameObject[] tips;
    public bool preferRight = true;

    // Use this for initialization
    void Start () {
        FindThumbs();
	}
	
	// Update is called once per frame
	void Update () {
        FindThumbs();
	}

    private void FindThumbs()
    {
        tips = GameObject.FindGameObjectsWithTag("Erase");
        foreach (GameObject tip in tips)
        {
            if (tip.name.Contains("R"))
            {
                thumbRight = tip;
                //Debug.Log("Have a right thumb.");
            }
            if (tip.name.Contains("L"))
            {
                thumbLeft = tip;
                //Debug.Log("Have a left tip.");
            }
        }
        if (preferRight)
        {
            thumbPrefer = thumbRight;
        }
        else
        {
            thumbPrefer = thumbLeft;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == thumbPrefer.name)
        {
            Debug.Log("Erasing things!");
            Destroy(this.gameObject);
        }
    }
}
