using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public Rigidbody board;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(board, transform.position, transform.rotation) as Rigidbody;
        }
    }

    void OnPress()
    {

    }
}
