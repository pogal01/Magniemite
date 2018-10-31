using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour {


    [SerializeField] private Transform player;
    [SerializeField] private Transform Point1;
    [SerializeField] private Transform Point2;
    [SerializeField] private Transform Point3;
    [SerializeField] private Transform Point4;
    [SerializeField] private Transform Point5;
    [SerializeField] private Transform Point6;
    [SerializeField] private Transform Point7;
    [SerializeField] private Transform Point8;
    [SerializeField] private Transform Point9;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("1"))
        {
            player.transform.position = Point1.transform.position;
        }
        if (Input.GetKeyUp("2"))
        {
            player.transform.position = Point2.transform.position;
        }
        if (Input.GetKeyUp("3"))
        {
            player.transform.position = Point3.transform.position;
        }
        if (Input.GetKeyUp("4"))
        {
            player.transform.position = Point4.transform.position;
        }
        if (Input.GetKeyUp("5"))
        {
            player.transform.position = Point5.transform.position;
        }
        if (Input.GetKeyUp("6"))
        {
            player.transform.position = Point6.transform.position;
        }
        if (Input.GetKeyUp("7"))
        {
            player.transform.position = Point7.transform.position;
        }
        if (Input.GetKeyUp("8"))
        {
            player.transform.position = Point8.transform.position;
        }
        if (Input.GetKeyUp("9"))
        {
            player.transform.position = Point9.transform.position;
        }

    }
}
