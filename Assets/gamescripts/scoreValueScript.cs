﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreValueScript : MonoBehaviour {

    public Text txt;

	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
        txt.text = "score: " + (float) GlobalScore.playerScore*100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
