using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyEventer : MonoBehaviour
{
    public GameObject MyFunny;
    public Sprite postClick;
 
    void OnMouseDown()
    {
        //enable the drop and set in motion
        MyFunny.SetActive(true);
        Debug.Log("clicked");
       if(postClick!=null)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = postClick;
            
        }
        
        //change image to post clicked
        
    }
    // Start is called before the first frame update
}
