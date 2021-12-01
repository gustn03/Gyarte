using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private float camStartpos;
    void start()
    {
        camStartpos = transform.position.x;
    }
    void Update()
    {
        float playerPos = (player.transform.position.x);

        transform.position = new Vector3(camStartpos + playerPos, transform.position.y, transform.position.z);
    }
}
