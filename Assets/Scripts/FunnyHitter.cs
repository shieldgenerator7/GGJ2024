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
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (destroyOnContact) { 
        if (collision.gameObject.tag == "Player")
        {
            thePlayer = collision.gameObject;
            Debug.Log("HIT "+ messName);
            //call player object to stop moving

            Destroy(this.gameObject);
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
