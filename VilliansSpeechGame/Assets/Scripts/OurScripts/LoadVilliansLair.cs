﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadVilliansLair : MonoBehaviour {


    public Button yourButton;

	// Use this for initialization
	void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(SwitchToVilliansLair);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchToVilliansLair()
    {
        SceneManager.LoadScene(1);
    }
}
