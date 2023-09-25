using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 25.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    //variables for camera switcher function
    public Camera mainCamera;
    public Camera driverCam;
    public KeyCode switchKey;

    //
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //forward and horizontal controls for player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical"+ inputID);

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        //if statement to choose driver camera
       // if (Input.GetKeyDown(switchKey))
        //{
       //     mainCamera.enabled = !mainCamera.enabled;
       //     driverCam.enabled = !driverCam.enabled;
       // }

    }



}
