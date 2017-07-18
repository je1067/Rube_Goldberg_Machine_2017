using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    public GameObject Cube;
    public GameObject StartText;
	
	void Start () {
		
	}
	
	
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            Cube.SetActive(false);
            StartText.SetActive(false);
        }
	}
}
