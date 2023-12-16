using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public int spawnRate = 3;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            System.Random rnd = new System.Random();
            int randomYAxis = rnd.Next(-6, 6);
            Vector3 faruk = new Vector3(transform.position.x, randomYAxis, 0);

            Instantiate(Pipe, faruk , transform.rotation);
            time = 0;
        }
    }
}
