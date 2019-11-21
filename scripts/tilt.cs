using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    // Start is called before the first frame update
    private Quaternion localRotation; 


    void Start()
    {
        localRotation = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        float xTilt = Input.GetAxis("Vertical")+ Input.acceleration.y;
        float zTilt = -Input.GetAxis("Horizontal")- Input.acceleration.x;
        transform.Rotate(xTilt,0,zTilt);
    }

}
