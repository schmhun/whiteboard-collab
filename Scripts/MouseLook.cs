using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public enum RotationAxes
	{
		MouseXandY = 0,
		MouseX = 1,
		MouseY = 2,
	}

	public RotationAxes axes = RotationAxes.MouseXandY;

	public enum AirplaneMode
	{
		Normal = 1,
		Inverted = -1,
	}
	public AirplaneMode inv = AirplaneMode.Normal;

	public float sensitivityHor = 3.0f;
	public float sensitivityVer = 3.0f;
	public float minVert = -45.0f;
	public float maxVert = 45.0f;

	private float _rotationX = 0.0f;

	public void ChangeX(){
		transform.Rotate(0,Input.GetAxis("Mouse X")*sensitivityHor,0);
	}

	public void ChangeY(){
		if (inv == AirplaneMode.Inverted) {
			_rotationX += Input.GetAxis ("Mouse Y") * sensitivityVer;
		} else {
			_rotationX -= Input.GetAxis ("Mouse Y") * sensitivityVer;
		}
		_rotationX = Mathf.Clamp (_rotationX, minVert, maxVert);

		float rotationY = transform.localEulerAngles.y;
		transform.localEulerAngles = new Vector3 (_rotationX, rotationY, 0);
	}

	// Use this for initialization
	void Start () {
		Rigidbody body = GetComponent<Rigidbody> ();
		if (body != null) {
			body.freezeRotation = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (axes == RotationAxes.MouseX) {
			//horizontal rotation
			ChangeX();
		} else if (axes == RotationAxes.MouseY) {
			//vertical rotation
			ChangeY();
		} else {
			// TODO: Check for delta changes in Shep's code
			//both horizontal & vertical rotation
			ChangeX ();
			ChangeY ();
		}


	}
}
