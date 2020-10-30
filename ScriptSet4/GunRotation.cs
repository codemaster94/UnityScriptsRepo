using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public float rotationSpeed=5;
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 5) * Time.deltaTime*rotationSpeed);
    }

    
}
