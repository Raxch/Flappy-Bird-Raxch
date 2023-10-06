using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipePosition : MonoBehaviour
{
    float randomY;
    public int time;
    int turnLeft = 1;
    int maxObject = 0;
    void Start()
    {
        randomY = Random.Range(-2.3f, 2.3f);

        transform.position = new Vector2 (transform.position.x, randomY);

        maxObject++;
    }

    void Update()
    {
        turnLeft++;
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * turnLeft, Time.deltaTime * time);
    }
}
