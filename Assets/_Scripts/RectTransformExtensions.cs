using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RectTransformExtensions
{ 
	public static void SetSize(this RectTransform trans,Vector2 newSize)
	{

		Vector2 oldSize = trans.rect.size;

		Vector2 delatSize = newSize - oldSize;

		trans.offsetMin = trans.offsetMin - new Vector2(delatSize.x * trans.pivot.x, delatSize.y * trans.pivot.y);

		trans.offsetMax = trans.offsetMax + new Vector2(delatSize.x * (1f - trans.pivot.x), delatSize.y*(1f - trans.pivot.y));
	}
	
	public static void SetWidth(this RectTransform trans,float newSize)
	{
		SetSize(trans, new Vector2(newSize, trans.rect.size.y));
	}

	public static void SetHieght(this RectTransform trans,float newSize)
	{
		SetSize(trans, new Vector2(trans.rect.size.x, newSize));
	}
}
