﻿using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public static PauseMenu menu;

	void Awake () {
		if (menu == null) {
			Debug.Log ("dontdestroy");
			DontDestroyOnLoad(gameObject);
			menu = this;
			menu.gameObject.SetActive(true);
		} else if (menu != this) {
			Debug.Log("destroy");
			Destroy(gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "StartMenu")
			Destroy (gameObject);
	
	}

}
