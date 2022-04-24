﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElisePlayerController : MonoBehaviour
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    public int gemsneeded = 3;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    void Start()
    {
        transform.position = new Vector3(1, -2, 0);
    }

    // Use this for initialization
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        //transform.position = new Vector3(1, -2, 0);
    }

    void Update()
    {
        if (transform.position.x >= 33)
        {
            transform.position = new Vector3(33, transform.position.y, 0);
        }
        if (transform.position.y >= 20)
        {
            transform.position = new Vector3(transform.position.x, 20, 0);
        }
    }

    public void FixedUpdate()
    {
        Vector2 move = Vector2.zero;


        move.x = Input.GetAxis("Horizontal");
        if (move.x > 0.01f)
        {
            if (spriteRenderer.flipX == true)
            {
                spriteRenderer.flipX = false;
            }
            move.y = rb.velocity.y;
            rb.velocity = new Vector2(move.x * maxSpeed, move.y);

        }
        else if (move.x < -0.01f)
        {
            if (spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
            }

            move.y = rb.velocity.y;
            rb.velocity = new Vector2(move.x * maxSpeed, move.y);
            //rb.velocity = new Vector2(move.x * maxSpeed, rb.velocity.y);
            //rb.AddForce(move * maxSpeed, ForceMode2D.Impulse);

        }
        /*
        if (GameManager.greengem >= gemsneeded && GameManager.redgem >= gemsneeded && GameManager.bluegem >= gemsneeded)
            loadnextlevel();*/
    }
    /*
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */
}
