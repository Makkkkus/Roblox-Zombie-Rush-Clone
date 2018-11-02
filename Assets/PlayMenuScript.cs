﻿using UnityEngine;

public class PlayMenuScript : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void EnableMenu()
    {
        gameObject.SetActive(true);
    }
    
    public void DisableMenu()
    {
        gameObject.SetActive(false);
    }
}
