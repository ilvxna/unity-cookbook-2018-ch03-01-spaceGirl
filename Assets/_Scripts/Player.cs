using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	private InventoryManager inventoryManager;


	private void Start()
	{
		inventoryManager = GetComponent<InventoryManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("PickUp"))
		{
			PickUp item = collision.GetComponent<PickUp>();

			if (item!=null)
			{
				inventoryManager.Add(item);
			}
			
			Destroy(collision.gameObject);
		}
	}
}
