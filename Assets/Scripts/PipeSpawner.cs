using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 4;
    public float timer = 0;
    public float lowRange, highRange;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0;
        }
    }

    // this is spawn function and run when its called.
    void Spawn()
    {
        Instantiate(pipe, transform.position, transform.rotation);

        transform.position = new Vector3(transform.position.x, Random.Range(lowRange, highRange), transform.position.z);
    }
}
