﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public int sceneToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
        LoadSceneNumber(sceneToLoad);
	}

    public void LoadSceneNumber (int number) {
        SceneManager.LoadScene(number);
    }
}
