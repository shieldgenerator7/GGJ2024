using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public float floatSpeed = 1;
    public float floatDuration = 3;
    private float foundStartTime = 0;
    private bool found = false;

    public AudioClip foundSound;

    private SpriteRenderer sr;
    private new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = foundSound;
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!found)
        {
            found = true;
            foundStartTime = Time.time;
            audio.Play();
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
            //
            if (Time.time > foundStartTime + floatDuration && !audio.isPlaying)
            {
                Debug.Log("finished easter egg " + gameObject.name);
                Destroy(gameObject);
            }
        }
    }

}
