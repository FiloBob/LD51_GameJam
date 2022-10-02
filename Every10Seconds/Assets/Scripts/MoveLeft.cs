using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public float leftForce;
    public Rigidbody obstacleRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        obstacleRb.AddForce(-leftForce * Time.deltaTime * speed, 0, 0);
        //transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
