using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform Checkpoint2;
    [SerializeField] private Transform StartingPoint;
    public GameObject Theplayer;
    public GameObject Respawnpoint1;
    public GameObject Respawnpoint2;
    public GameObject StartPoint;
    public GameObject Camback;
    public GameObject Cambackpos;
	public bool respawn = true;
	public bool Reset =false;
	

    void Start()
    {
        respawnPoint = StartingPoint;
		respawn = false;
		Reset = false;
	}


    void OnTriggerEnter(Collider other)
    {
		
		if (other.tag == "Player")
		{
			player.transform.position = respawnPoint.transform.position;
			Camback.transform.position = Cambackpos.transform.position;
			Camback.transform.parent = Cambackpos.transform;
			Reset = true;
			respawn = true;
			if (Reset == true && respawn == true)
			{

				Reset = false;
				respawn = true;

			}
		}
			
			

		
      
    }

    void Update()
    {


        if (GameObject.Find("FirstGoalTrigger").GetComponent<Level1End>().CheckPoint1)
        {
            respawnPoint = Checkpoint2;
        }


		


    }
}


