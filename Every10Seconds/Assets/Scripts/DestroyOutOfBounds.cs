using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float rangeY = 17f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -20 || transform.position.x > 40)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -rangeY || transform.position.y > rangeY)
        {
            Destroy(gameObject);
        }
    }
}
