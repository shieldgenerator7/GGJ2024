using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantAngle : MonoBehaviour
{

    public Vector2 direction = Vector2.up;

    // Update is called once per frame
    void Update()
    {
        transform.up = direction;
    }
}
