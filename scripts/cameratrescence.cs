using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratrescence : MonoBehaviour
{ 
public GameObject objectToFollow;
private Vector3 offset;
public float speed = 2.0f;
public float cam = 0.1f;
private void Start()
{


}



void FixedUpdate()
{
    float interpolation = speed * Time.deltaTime;

    Vector3 position = this.transform.position;
    position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, interpolation) + 0.08f;
    position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);
    position.z = Mathf.Lerp(this.transform.position.z, objectToFollow.transform.position.z, interpolation);

    this.transform.position = position;
}
}