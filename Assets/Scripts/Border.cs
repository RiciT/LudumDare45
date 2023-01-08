using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public float moveSpeed = 0.3f;
    public GameObject player;
    public float distFromPlayer = 15f;

    void Update()
    {
        if (gameObject.transform.position.x < player.transform.position.x - distFromPlayer)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x - distFromPlayer, transform.position.y, transform.position.z);
        }    
    }
    void FixedUpdate()
    {
        transform.position += new Vector3(moveSpeed, 0f, 0f);   
    }
}
