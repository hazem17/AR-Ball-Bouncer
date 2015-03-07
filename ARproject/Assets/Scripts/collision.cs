using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("here");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("here col");
            //Destroy(col.gameObject);
        }
    }
}
