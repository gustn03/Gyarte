using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private float camStartposX;
    private float camStartposY;
    public float delay;
    void start()
    {
        camStartposX = transform.position.x;
        camStartposY = transform.position.y;
    }
    void Update()
    {
        float playerPosX = (player.transform.position.x * delay);
        float playerPosY = (player.transform.position.y);

        transform.position = new Vector3(camStartposX + playerPosX, camStartposY + playerPosY, transform.position.z);
    }
}
