using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nej : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D controller;
    void Update()
    {
        if (player.transform.position.x > 59){
            controller.m_MovementSmoothing = 0.8f;
            controller.m_AirControl = false;
        }
        else{
            controller.m_MovementSmoothing = 0.2f;
            controller.m_AirControl = true;
        }
    }
}
