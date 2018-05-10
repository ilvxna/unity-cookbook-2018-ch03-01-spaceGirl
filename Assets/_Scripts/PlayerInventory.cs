using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {


	private PlayerInventoryDisplay playerInventoryDisplay;

	private bool carringStar = false;

	// Use this for initialization
	void Start () {
		playerInventoryDisplay = this.gameObject.GetComponent<PlayerInventoryDisplay>();

		playerInventoryDisplay.onChangeCarringStar(carringStar);
	}
	
	// Update is called once per frame
	void Update () {

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Star"))
		{
			carringStar = true;

			playerInventoryDisplay.onChangeCarringStar(carringStar);

			Destroy(collision.gameObject);
		}
	}

}
