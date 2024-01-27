using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyEventer : MonoBehaviour
{
    public GameObject MyFunny;
 
    void OnMouseDown()
    {
        //enable the drop and set in motion
        MyFunny.SetActive(true);
        Debug.Log("clicked");

        //change image to post clicked
        
    }
    // Start is called before the first frame update
}
