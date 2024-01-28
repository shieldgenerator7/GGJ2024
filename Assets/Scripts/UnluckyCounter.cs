using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnluckyCounter : MonoBehaviour
{
    [SerializeField]
    private int count = 0;

    public TMP_Text txtCount;

    public int Count
    {
        get => count;
        private set
        {
            count = value;
            OnCountChanged?.Invoke(count);
        }
    }
    public Action<int> OnCountChanged;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
        OnCountChanged += (count) =>
        {
            txtCount.text = $"Insurance Claim: ${count * 100 + 1000}";
        };
        SceneManager.sceneLoaded += (a, b) =>
        {
            registerPlayerDelegates();
        };
        registerPlayerDelegates();
    }

    private void registerPlayerDelegates()
    {
        FindAnyObjectByType<PlayerController>().OnMovingChanged += (moving) =>
        {
            if (!moving)
            {
                Count++;
            }
        };
    }
}
