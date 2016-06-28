using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HideUnhide : MonoBehaviour {
    private CanvasGroup EntityCanvasGroup;
   
    // Use this for initialization
    void Start () {
        EntityCanvasGroup = GetComponent(typeof(CanvasGroup)) as CanvasGroup;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.H))
        {
            EntityCanvasGroup.alpha = 1- EntityCanvasGroup.alpha;
        }
    }
}
