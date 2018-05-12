using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	private PlayerInventoryDisplay playerInventoryDisplay;

	private Dictionary<PickUp.PickUpType, int> items = new Dictionary<PickUp.PickUpType, int>();

	// Use this for initialization
	void Start () {
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();

		playerInventoryDisplay.OnChangeInventory(items);
	}
	
	public void Add(PickUp pickUp)
	{
		PickUp.PickUpType type = pickUp.type;

		int oldTotal = 0;

		if (items.TryGetValue(type, out oldTotal))
		{
			items[type] = oldTotal + 1;
		}
		else
			items.Add(type, 1);

		playerInventoryDisplay.OnChangeInventory(items);
	}
}
