using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDetatch : MonoBehaviour {

    public GameObject cam;
    public GameObject player;


    //when something has enterd the trigger
    void OnTriggerEnter()
    {
        cam.transform.position = player.transform.position;
        cam.transform.parent = player.transform;
    }
}
