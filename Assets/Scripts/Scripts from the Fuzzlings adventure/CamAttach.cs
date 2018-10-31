using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAttach : MonoBehaviour {

    public GameObject cam;
    public GameObject empty;
  

    //when something has enterd the trigger
    void OnTriggerEnter()
    {
        cam.transform.position = empty.transform.position;
        cam.transform.parent = empty.transform;
    }
}
