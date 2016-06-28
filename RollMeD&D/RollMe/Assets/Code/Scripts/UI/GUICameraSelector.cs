using UnityEngine;
using System.Collections;

public class GUICameraSelector : MonoBehaviour {
    Canvas guiCanvas;
    
	// Use this for initialization
	void Start () {
        guiCanvas = this.gameObject.GetComponent(typeof(Canvas)) as Canvas;
        guiCanvas.worldCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
