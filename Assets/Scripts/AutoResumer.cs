using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResumer : MonoBehaviour
{
    public float waitDuration = 2;

    private bool waiting = false;
    private float waitStartTime = 0;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        playerController.OnMovingChanged += (moving) =>
        {
            if (!moving)
            {
                waiting = true;
                waitStartTime = Time.time;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (waiting)
        {
            if (Time.time > waitStartTime + waitDuration)
            {
                waiting = false;
                playerController.Moving = true;
            }
        }
    }
}
