using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moremove : MonoBehaviour
{
    static Animator animat;
    public float speed = 25.0F;
    public float jumpSpeed = 65.0F;
    public float gravity = 50.0F;
    public float rotateSpeed = 20.0F;
	public float mouseSensitivity = 100.0f;
	private Vector3 moveDirection = Vector3.zero;
	public bool Grounded = false;
	public bool Running = false;
	public bool Stop = false;
	public float clampAngle = 80.0f;
	private float rotX = 0.0f; // rotation around the right/x axis
	private float rotY = 0.0f; // rotation around the up/y axis
	


	// Use this for initialization
	void Start()
    {
        animat = GetComponent<Animator>();
		speed = 25.0F;
		Grounded = true;
		Running = false;
		Stop = false;
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;

	}

	// Update is called once per frame
	void Update()
	{


		
		float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = -Input.GetAxis("Mouse Y");

		translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        rotY += mouseX * mouseSensitivity * Time.deltaTime;
		rotX += mouseY * mouseSensitivity * Time.deltaTime;

		rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

		Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
		transform.rotation = localRotation;



		transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

		rotY += mouseY * mouseSensitivity * Time.deltaTime;


		if (Grounded == true)
		{
			if(Input.GetKeyDown(KeyCode.LeftShift))
			{
				Running = true;
				
			}
			


		}

		


		if(Running == true)
		{
			speed = 50.0f;

		}




		if(Grounded == false)
		{
			
		Running = false;


	    }
		
		if(Running == false)
		{
			speed = 25.0f;
		}



        if (translation != 0)
        {

            animat.SetBool("IsWalking", true);
			

		}
        else
        {
            animat.SetBool("IsWalking", false);
			Running = false;

		}


        //if the character is on the ground
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;

                animat.SetBool("IsInAir", false);
            }
            else
            {
                animat.SetBool("IsInAir", true);
            }

			Grounded = true;

		}
		else
		{
			Grounded = false;
		}
            //end of ground code


            moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

		//Rotate Player#
		transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
	
	
	
	}
}