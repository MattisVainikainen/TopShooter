using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    float rotSpeed = 20f;

    void OnMouseDrag() 
    {
        float rotX = Input.GetAxis("Horizontal") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Vertical") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
