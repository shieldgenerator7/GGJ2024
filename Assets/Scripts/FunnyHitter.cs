using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyHitter : MonoBehaviour
{
    public string messName;
    public GameObject thePlayer;
    public bool consumed; //hits ground and goes away = true ; stays to trip = false
    public bool flingMe;  // drops = false, moves towards player = true
    public float flingForce;
    public float flingUp;
    public bool rotateMe;
    public bool destroyOnContact = true;
    public Rigidbody2D myself;

    AudioSource audioData;
    public AudioClip myClip;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (destroyOnContact) { 
        if (collision.gameObject.tag == "Player")
        {
            thePlayer = collision.gameObject;
            Debug.Log("HIT "+ messName);
                //sendSound = thePlayer.GetComponent(AudioSource); 

                //call player object to stop moving
                //this.GetComponentInChildren<AudioSource>();

                audioData = GetComponent<AudioSource>();
                audioData.Play(0);
                Debug.Log("started");


                AudioSource clipPlayer = new AudioSource();
                clipPlayer = GetComponent<AudioSource>();
                BoxCollider2D boxedIn = GetComponent<BoxCollider2D>();
                boxedIn.enabled = false;
                // PlayMyTrack();
                Destroy(this.gameObject,3);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Grounded");
            if (consumed) { 
            Destroy(this.gameObject);
        }
        }
        }
    }
    private void Start()
    {
        myself = this.GetComponent<Rigidbody2D>();
        if (rotateMe) { 
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)); 
        }
        if(flingMe == true)
        {
            myself.AddForce(new Vector2(-flingForce, flingUp));
        }
    }
}
