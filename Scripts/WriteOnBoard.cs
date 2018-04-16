using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteOnBoard : MonoBehaviour {

    private GameObject tipLeft;
    private GameObject tipRight;
    private GameObject tipPrefer;
    private GameObject[] tips;
    public bool preferRight = true;

    public GameObject inkPrefab;

	// Use this for initialization
	void Start () {
        FindTips();
	}
	
	// Update is called once per frame
	void Update () {
        FindTips();
	}

    private void FindTips()
    {
        tips = GameObject.FindGameObjectsWithTag("Write");
        foreach (GameObject tip in tips)
        {
            if (tip.name.Contains("R"))
            {
                tipRight = tip;
                //Debug.Log("Have a right tip.");
            }
            if (tip.name.Contains("L"))
            {
                tipLeft = tip;
                //Debug.Log("Have a left tip.");
            }
        }
        if (preferRight)
        {
            tipPrefer = tipRight;
        }
        else
        {
            tipPrefer = tipLeft;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        if (other.gameObject.name == tipPrefer.name)
        {
            Debug.Log("We can write here!");
            GameObject clone = Instantiate(inkPrefab, other.transform.position, other.transform.rotation, transform);
        }
        else
        {
            //Debug.Log("No writeable collision found.");
        }
    }
}
