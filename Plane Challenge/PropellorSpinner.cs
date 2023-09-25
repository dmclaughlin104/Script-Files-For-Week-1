using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpinner : MonoBehaviour
{
    //variables
    private float speed = 70.0f;
    private Vector3 spinAxis = new Vector3(0,0,3);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates propellor every frame
        transform.Rotate(spinAxis * speed * Time.deltaTime);
        
    }
}
