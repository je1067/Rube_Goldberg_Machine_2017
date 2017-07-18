using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{

    public GameObject EndText;

    void Start()
    {
        EndText.SetActive(false);
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Object3")
        {

            Debug.Log("Object3 detects trigger");
            EndText.SetActive(true);
        }
    }
}
