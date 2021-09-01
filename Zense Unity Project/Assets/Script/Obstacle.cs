using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float time__bet_spawn;
    private float spawn_time;

    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawn_time)
        {
            Spawn();
            spawn_time = Time.time + time__bet_spawn;

        }
    }

    void Spawn()
    {
        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randX, randY, 0), transform.rotation);
    }
}
