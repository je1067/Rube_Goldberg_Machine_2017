using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;

    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Trigger3;

    public bool SetCam2;
    public bool SetCam3;
    public bool SetCam4;
    
	
	void Start () {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
	}
	
	
	void Update () {
		if (SetCam2 == (true))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
        }
        if (SetCam3  == (true))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Camera4.SetActive(false);
        }
        if (SetCam4 == (true))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(true);
        }
	}

    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Object1")
        {

            Debug.Log("Object1 detects trigger");
            SetCam2 = (true);
            SetCam3 = (false);
            SetCam4 = (false);
        }   

        if (coll.gameObject.tag == "Object2")
        {

            Debug.Log("Object2 detects trigger");
            SetCam3 = (true);
            SetCam2 = (false);
            SetCam4 = (false);

        }
        if (coll.gameObject.tag == "Object3")
        {

            Debug.Log("Object3 detects trigger");
            SetCam4 = (true);
            SetCam2 = (false);
            SetCam3 = (false);

        }
    }
}
