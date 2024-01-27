using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyHitter : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("HIT");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HITsss");
            Destroy(this.gameObject);
        }
        
    }
}
