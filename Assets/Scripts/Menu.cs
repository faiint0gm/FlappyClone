﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	void StartGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}