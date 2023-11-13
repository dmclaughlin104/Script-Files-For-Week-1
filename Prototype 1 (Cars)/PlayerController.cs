using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //private variables
    private Rigidbody playerRB;
    [SerializeField] float horsePower = 15000;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] GameObject centreOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float speed;
    [SerializeField] float rPM;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;


    //
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.centerOfMass = centreOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //forward and horizontal controls for player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);



        if (IsOnGround())
        {
            //Move the vehicle forward
            playerRB.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

            speed = Mathf.RoundToInt(playerRB.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");

            rPM = (speed % 30) * 40;
            rpmText.SetText("RPM: " + rPM);

        }


    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }


        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}
