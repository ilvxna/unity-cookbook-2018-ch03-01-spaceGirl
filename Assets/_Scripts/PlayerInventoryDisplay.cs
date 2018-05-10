using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour {


	public Text starText;
	public void onChangeCarringStar(bool carringStar)
	{
		string starMsg = "no star:-(";

		if (carringStar)
		{
			starMsg = "Carring Star :-)";
		}
		starText.text = starMsg;
	}


}
