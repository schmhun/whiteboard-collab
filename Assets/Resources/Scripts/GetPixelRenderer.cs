using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPixelRenderer : MonoBehaviour {

    public Renderer m_renderer;

    public Renderer Renderer {
        get {
            return m_renderer;
        }
        set {
            m_renderer = value;
        }
    }

	// Use this for initialization
	void Start () {
        m_renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
