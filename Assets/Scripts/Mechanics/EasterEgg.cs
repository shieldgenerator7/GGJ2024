using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public float floatSpeed = 1;
    public float floatDuration = 3;
    private float foundStartTime = 0;
    private bool found = false;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!found)
        {
            found = true;
            foundStartTime = Time.time;
        }
    }

    private void Update()
    {
        if (found)
        {
            //
            Color c = sr.color;
            c.a = Mathf.Lerp(1,0,(Time.time -  foundStartTime)/floatDuration);
            sr.color = c;
            //
            transform.position += Vector3.up * (floatSpeed * Time.deltaTime);
        }
    }

}
