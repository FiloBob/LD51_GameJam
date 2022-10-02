using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObstacle;


    private float spawnRate = 2f;
    private float waitTen = 0;
    private float cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        //obstacles
        waitTen += Time.deltaTime;
        Debug.Log("waitTen = " + waitTen);
        cooldown += Time.deltaTime;
        Debug.Log("cooldown = " + cooldown);
        //ten
        if (waitTen >= 10)
        {
            spawnRate /= 2;
            waitTen = 0;
        }
        Debug.Log("spawnRate = " + spawnRate);
        //spawn
        if (cooldown >= spawnRate)
        {
            SpawnObstacle();
            cooldown = 0;
        }

    }

    //spawn meteors
    void SpawnObstacle()
    {
      float randomY = Random.Range(1f, 8.8f);
     Vector3 spawnPos = new Vector3(30, randomY, 0);

     Instantiate(spawnObstacle, spawnPos, Quaternion.identity);
    }

}
