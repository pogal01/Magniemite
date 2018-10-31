using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraEvents : MonoBehaviour
{
    [SerializeField]
    Camera camera1; //Back
    [SerializeField]
    Camera camera2; //front
    [SerializeField]
    Camera camera3; //first person
   
                    // These are my cams for the fuzzling
    private bool switchCam = false;
    private bool backCam = false;
    ActivatedFallingball ramp;



    void Start()
    {
       
        camera1.GetComponent<Camera>().enabled = true;
        camera2.GetComponent<Camera>().enabled = false;
        camera3.GetComponent<Camera>().enabled = false;
       

    }


    void Update()
    {
        if (Input.GetKeyUp("f"))
        {
            switchCam = !switchCam;
            backCam = false;
        }
        if (Input.GetKeyUp("g"))
        {
            switchCam = false;
            backCam = true;
        }
      
        if (switchCam == true)
        {
            camera1.GetComponent<Camera>().enabled = false;
            camera2.GetComponent<Camera>().enabled = false;
            camera3.GetComponent<Camera>().enabled = true;
        }
        else if (backCam == true)
        {
            camera1.GetComponent<Camera>().enabled = false;
            camera2.GetComponent<Camera>().enabled = true;
            camera3.GetComponent<Camera>().enabled = false;
        }
        else
        {
            camera1.GetComponent<Camera>().enabled = true;
            camera2.GetComponent<Camera>().enabled = false;
            camera3.GetComponent<Camera>().enabled = false;
        }
    }
}