using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class PlayerInventoryDisplay : MonoBehaviour
{
	

	const int NUM_INVENTORY_SLOTS = 10;

	private PickupUI[] slots = new PickupUI[NUM_INVENTORY_SLOTS];

	public GameObject slotGrid;

	public GameObject starSlotPrefab;
	private Text inventoryText;

	private void Awake()
	{
		for (int i = 0; i < NUM_INVENTORY_SLOTS; i++)
		{
			GameObject starSlotGo = (GameObject)Instantiate(starSlotPrefab);
			///设置父节点在Grid上面
			starSlotGo.transform.SetParent(slotGrid.transform);

			starSlotGo.transform.localScale = new Vector3(1, 1, 1);

			slots[i] = starSlotGo.GetComponent<PickupUI>();
		}
	}
	public void OnChangeInventory(Dictionary<PickUp.PickUpType,int> inventory)
	{
		/* 
		 * alphabetical sorting of List
		 * 

		inventory.Sort(
			delegate(PickUp p1, PickUp p2){
			return p1.description.CompareTo(p2.description);
		}
		);
		
		*/
		
		// (1) clear existing display
		inventoryText.text = "";

		// (2) build up new set of items 
		string newInventoryText = "carrying: ";
		int numItems = inventory.Count;
		foreach (var item in inventory)
		{
			int itemTotal = item.Value;

			string description = item.Key.ToString();

			newInventoryText += " [ " + description + " " + itemTotal + " ]";
		}
		if (numItems < 1) newInventoryText = "(empty inventory)";

		// (3) update screen display
		inventoryText.text = newInventoryText;
	}

	public void OnChangeStarTotal(int starTotal)
	{
		for (int i = 0; i < NUM_INVENTORY_SLOTS; i++)
		{
			PickupUI slot = slots[i];

			if (i < starTotal)
			{
				slot.DisplayYellow();
			}
			else
				slot.DisplayGrey();
		}
	}
}
