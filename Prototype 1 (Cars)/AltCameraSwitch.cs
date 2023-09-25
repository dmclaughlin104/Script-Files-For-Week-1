using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//alternative camera switch class. I can't get it working where the same button toggles on/off
public class AltCameraSwitch : MonoBehaviour
{
    //alternative camera objects
    public Camera mainCamera;
    public Camera driverCam;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //if statement to choose driver camera
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            driverCam.enabled = !driverCam.enabled;
        }

    }
}
