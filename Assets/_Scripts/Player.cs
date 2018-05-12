using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	private PlayerInventoryDisplay playerInventoryDisplay;

	private List<PickUp> inventory = new List<PickUp>();

	private void Start()
	{
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
		playerInventoryDisplay.OnChangeInventory(inventory);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("PickUp"))
		{
			PickUp item = collision.GetComponent<PickUp>();

			if (item!=null)
			{
				inventory.Add(item);
			}
			playerInventoryDisplay.OnChangeInventory(inventory);

			Destroy(collision.gameObject);
		}
	}
}
