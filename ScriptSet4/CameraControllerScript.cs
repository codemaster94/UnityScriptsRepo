using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    public Transform mychef;

    private void FixedUpdate()
    {
        transform.position = new Vector3(mychef.position.x, transform.position.y, transform.position.z);
    }
}
