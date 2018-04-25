using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerToPixel : MonoBehaviour {

    public Material new_Material;

    private const string Path = "Materials/InkBlack";


    // Use this for initialization
    void Start () {
        new_Material = (Material)Resources.Load(Path, typeof(Material));
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Other name: "+other.name);
        Debug.Log("Other tag: " + other.tag);

        if (other.CompareTag("Writeable"))
        {
            Renderer drawReceiver = other.GetComponent<Renderer>();
            //GetPixelRenderer pixel = other.gameObject as GetPixelRenderer;
            //pixel.Renderer.material = new_Material;
            drawReceiver.material = new_Material;
        }
    }
}
