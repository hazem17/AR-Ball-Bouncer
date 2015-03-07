using UnityEngine;
using System.Collections;

public class cloudObject : MonoBehaviour, ICloudRecoEventHandler {


    CloudRecoBehaviour myCloud;
    public GameObject myObject;
	// Use this for initialization
	void Start () {
        myCloud = GetComponent<CloudRecoBehaviour>();
        myCloud.RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnInitError(TargetFinder.InitState initError)
    {
        
    }

    public void OnInitialized()
    {
        
    }

    public void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult)
    {
        Instantiate(myObject, new Vector3(0, 0, 0), Quaternion.identity);
        
    }

    public void OnStateChanged(bool scanning)
    {
        
    }

    public void OnUpdateError(TargetFinder.UpdateState updateError)
    {
        
    }
}
