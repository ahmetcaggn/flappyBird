using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float movementSpeed;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        //destroy pipe that out of the scene
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
