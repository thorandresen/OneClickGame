﻿using UnityEngine;
using System.Collections;

public class BubbleBehaviour : MonoBehaviour
{
    float speed;

    public float SpeedMax;
    public float SpeedMin;

    float xMovement = 1;

	void Start ()
	{
	    float scale = Random.Range(-0.4f, 0.4f);
	    transform.localScale = new Vector2(transform.localScale.x + scale, transform.localScale.y + scale);
	    speed = Random.Range(SpeedMin, SpeedMax);


	}

	void Update () 
    {
	    Movement();
	}

    void Movement()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);

        if (!GameObject.Find("Player").GetComponent<PlayerBehaviour>().gameOver || GameObject.Find("Player").GetComponent<PlayerBehaviour>().firstStart)
        transform.Translate(Vector2.left * Time.deltaTime * xMovement);


        if (transform.position.y > 5.557 || transform.position.x < -3.71)
        {
            Destroy(gameObject);
        }
    }
}
