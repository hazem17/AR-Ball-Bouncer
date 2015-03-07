using UnityEngine;
using System.Collections;

public class buttonHandle : MonoBehaviour,IVirtualButtonEventHandler{

    public GameObject cube;
    VirtualButtonBehaviour[] vbs;
    
	// Use this for initialization
	void Start () {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        foreach (VirtualButtonBehaviour btn in vbs)
        {
            btn.RegisterEventHandler(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        cube.renderer.material.color = Color.red;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        cube.renderer.material.color = Color.white;
    }
}
