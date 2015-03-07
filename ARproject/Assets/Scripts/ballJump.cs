using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ballJump : MonoBehaviour {

    public Text txt;
    private int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("hereeeee00");
        if (col.gameObject.tag == "Ball")
        {
            score++;
            txt.text = "Score: " + score;
            Debug.Log("hereeeee00");
            //Destroy(col.gameObject);
            //col.gameObject.rigidbody.velocity = new Vector3(0,300,0);//(1, 30, 1, ForceMode.Impulse);
            col.gameObject.rigidbody.AddForce(0, 30, 0, ForceMode.Acceleration);
        }
    }
}
