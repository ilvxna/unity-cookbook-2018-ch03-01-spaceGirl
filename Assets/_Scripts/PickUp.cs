using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	public PickUpType type;

	public enum PickUpType
	{
		Star,Key,Heart
	}
}
