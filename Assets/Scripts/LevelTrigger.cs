using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{
    public float waitTime = 1;
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController pc = collision.gameObject.GetComponent<PlayerController>();
            pc.Moving = false;
            pc.GetComponent<AutoResumer>().waitDuration = waitTime;
            pc.OnMovingChanged += (moving) =>
            {
                if (moving)
                {

                    SceneManager.LoadScene(sceneName);
                }
            };
        }
    }
}
