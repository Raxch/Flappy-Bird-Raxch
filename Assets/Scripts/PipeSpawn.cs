using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    float time = 0;
    float timer = 2;
    public GameObject pipe;
    void Update()
    {
        if (time <= 0) 
        {
            Instantiate(pipe, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }

        
    }
}
