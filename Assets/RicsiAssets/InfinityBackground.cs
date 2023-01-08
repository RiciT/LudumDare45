using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityBackground : MonoBehaviour
{
    public Transform genPoint;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + 40.9f, 0, 1);
            Instantiate(background, transform.position, transform.rotation);
        }
    }
}
