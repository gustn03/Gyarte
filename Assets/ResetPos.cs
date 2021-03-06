using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    private float originalX;
    private float originalY;
    void Start()
    {
        originalX = transform.position.x;
        originalY = transform.position.y;
    }
     void Update()
    {
        if (transform.position.y < -15f)
        {
            transform.position = new Vector3(originalX, originalY, transform.position.z);
        }   
    }
}
