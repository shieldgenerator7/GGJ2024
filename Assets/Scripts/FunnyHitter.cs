using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyHitter : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HITsss");
            //call player object to stop moving 
            Destroy(this.gameObject);
        }else if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Grounded");
            Destroy(this.gameObject);
        }
        
    }
    private void Start()
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
    }
}
