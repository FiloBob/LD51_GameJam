using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public GameObject prefabShot;
    public float shotCooldown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move up
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Acceleration);
        }
        //move down
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * speed, ForceMode.Acceleration);
        }


        //shot
        shotCooldown += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && shotCooldown >= 3)
        {
            Instantiate(prefabShot, transform.position, prefabShot.transform.rotation);
            shotCooldown = 0;
        }
    }
}
