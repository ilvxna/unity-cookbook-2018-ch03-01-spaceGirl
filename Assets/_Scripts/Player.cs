using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {

	private PlayerInventoryDisplay playerInventoryDisplay;


	private int totalStars = 0;

	void Star()
	{
		playerInventoryDisplay = this.gameObject.GetComponent<PlayerInventoryDisplay>();
	}

	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Star"))
		{
			totalStars++;
			playerInventoryDisplay.OnChangeStarTotal(totalStars);

			
				Destroy(collision.gameObject);
		}		
	} 

}
