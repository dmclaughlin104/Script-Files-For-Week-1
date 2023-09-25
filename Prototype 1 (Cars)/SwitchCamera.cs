using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to allow camera views to switch using the 1, 2 and 3 keys
public class SwitchCamera : MonoBehaviour
{
    //alternative camera objects
    public GameObject mainCamera;
    public GameObject driverCam;
    public GameObject rearViewCam;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to choose main camera
        if (Input.GetButtonDown("1Key"))
        {
            driverCam.SetActive(false);
            rearViewCam.SetActive(false);
            mainCamera.SetActive(true);
        }

        //if statement to choose driver camera
        if (Input.GetButtonDown("2Key"))
        {
            driverCam.SetActive(true);
            rearViewCam.SetActive(false);
            mainCamera.SetActive(false);
        }

        //if statement to choose rearview camera
        if (Input.GetButtonDown("3Key"))
        {
            driverCam.SetActive(false);
            rearViewCam.SetActive(true);
            mainCamera.SetActive(false);
        }
    }
}
