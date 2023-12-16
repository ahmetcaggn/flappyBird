using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public int flapStrength;

    public Text highscore;
    public LogicScript logic;
    public Transform mc;
    float bird1 = 0;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.gravityScale = 10;
        flapStrength = 40;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        Time.timeScale = 1;
    }
    // void DereceAyarla(int a)
    // {
    //     bird1 = myRigidBody.transform.rotation.z;
    //     if(a == 1){
    //         bird1+=20;
    //     }else if(a == 0){
    //         bird1=0;
    //     }else{
    //         bird1-=20;
    //     }
    // }


    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && logic.isAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 23 || transform.position.y < -23)
        {
            logic.gameOver();
        }

        // if (myRigidBody.velocity.y > 1)
        // {

        //     DereceAyarla(1);
        //     myRigidBody.MoveRotation(bird1);
        // }
        // else if(myRigidBody.velocity.y > -1){
        //     DereceAyarla(0);
        //     myRigidBody.MoveRotation(bird1);
        // }
        // else
        // {
        //     DereceAyarla(-1);
        //     myRigidBody.MoveRotation(bird1);
        // }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
