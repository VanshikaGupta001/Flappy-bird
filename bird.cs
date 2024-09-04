using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{  public Rigidbody2D myrigidbody;
public LogicScript logic;
public float flapstrength;
public bool birdIsAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
        myrigidbody.velocity=Vector2.up*flapstrength;}
    }
    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive=false;
    }
}
