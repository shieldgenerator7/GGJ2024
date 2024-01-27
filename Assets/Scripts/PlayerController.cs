using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;

    private bool moving = true;
    public bool Moving
    {
        get => moving;
        set
        {
            moving = value;
            OnMovingChanged?.Invoke(moving);
        }
    }
    public Action<bool> OnMovingChanged;


    private Rigidbody2D rb2d;

    public static PlayerController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = rb2d.velocity;
        vel.x = (moving) ? moveSpeed : 0;
        rb2d.velocity = vel;
    }
}
