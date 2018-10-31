using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttatch : MonoBehaviour { 

    public GameObject Object;
    public GameObject ThePlayer;
    static Animator AnimatStopPlat;
    public bool attached = false;

    // public GameObject FrontCam;

    void Start()
    {
        AnimatStopPlat = GetComponent<Animator>();
        attached = false;
        AnimatStopPlat.SetBool("StopMPlat", true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            ThePlayer.transform.parent = Object.transform;
            AnimatStopPlat.SetBool("StopMPlat", false);
            attached = true;


        }



    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        AnimatStopPlat.SetBool("StopMPlat", true);
        attached = false;
        ThePlayer.transform.parent = null;
    }

}
