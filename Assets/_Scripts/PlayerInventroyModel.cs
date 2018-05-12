using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventroyModel : MonoBehaviour {

	private int starTotal = 0;

	private PlayerInventoryDisplay playerInventoryDisplay;
	// Use this for initialization
	void Start () {
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();

		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}
	
	public void AddStar()
	{
		starTotal++;
		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}
}
