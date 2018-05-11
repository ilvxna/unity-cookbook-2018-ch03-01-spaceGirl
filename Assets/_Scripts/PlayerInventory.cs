using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {


	private PlayerInventoryDisplay playerInventoryDisplay;

	private int totalStars = 0;

	// Use this for initialization
	void Start () {
		playerInventoryDisplay = this.gameObject.GetComponent<PlayerInventoryDisplay>();

		
	}
	
	// Update is called once per frame
	void Update () {

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
