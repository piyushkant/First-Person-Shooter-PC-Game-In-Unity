using UnityEngine;
using System.Collections;

public class robotMove : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 200;

    //private int curSpeed = 0;
    private CharacterController controller;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        // Rotate around y-axis
        float newRotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(0, newRotation * Time.deltaTime, 0);

        // Calculate speed
        float newSpeed = Input.GetAxis("Vertical") * speed;
        if (Input.GetKey("left shift"))
        {
            newSpeed *= 1.5f;
        }

        controller = GetComponent<CharacterController>();
        controller.SimpleMove(transform.TransformDirection(Vector3.forward) * newSpeed);  
      	
        // Update the speed in the Animation script
    	SendMessage("SetCurrentSpeed", newSpeed, SendMessageOptions.DontRequireReceiver);
	    SendMessage("SetCurrentLean", Input.GetAxis("Horizontal"), SendMessageOptions.DontRequireReceiver);
	}
}
