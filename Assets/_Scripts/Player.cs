﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {

	public Text starText;

	private bool carringStar = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Star"))
		{
			carringStar = true;
			
			Destroy(collision.gameObject);
		}		
	} 

}
