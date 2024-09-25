using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float yPos;
    public float speed = 1f;
    public float direction = 1f;
    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;  
    }

    // Update is called once per frame
    void Update()
    {
        // Move the platform up and down
        transform.position = new Vector3(transform.position.x, yPos + direction*Mathf.PingPong(Time.time * speed, 3), transform.position.z);
    }
}
