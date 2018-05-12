using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	private InventoryManager inventoryManager;

	private PlayerInventroyModel playerInventroyModel;
	private void Start()
	{
		inventoryManager = GetComponent<InventoryManager>();

		playerInventroyModel = GetComponent<PlayerInventroyModel>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("PickUp"))
		{
			playerInventroyModel.AddStar();
			
			Destroy(collision.gameObject);
		}
	}
}
