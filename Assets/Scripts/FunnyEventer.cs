using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyEventer : MonoBehaviour
{
    public GameObject MyFunny;
    public Sprite postClick;
    public bool hideOnClick = false;
 
    void OnMouseDown()
    {
        //enable the drop and set in motion
        MyFunny.SetActive(true);
        Debug.Log("clicked");
       if(postClick!=null)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = postClick;
            
        }
       GetComponent<Collider2D>().enabled = false;
        
        if (hideOnClick)
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        //change image to post clicked
        
    }
    // Start is called before the first frame update
}
