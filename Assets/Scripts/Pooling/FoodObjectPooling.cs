﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoodObjectPooling : MonoBehaviour {

	private static List<GameObject> objectPool = new List<GameObject>();

	public static GameObject Spawn(GameObject prefab)
	{
		GameObject g = objectPool.Find(IsInactiveObject);

		if (g == null)
		{
			g = Object.Instantiate(prefab) as GameObject;
			objectPool.Add (g);
			return g;
		}
		else
		{
			g.SetActive(true);
			return g;
		}
	}

	static bool IsInactiveObject(GameObject g)
	{
		return !g.activeSelf;
	}
	
	static public bool IsActiveObject (GameObject g) {
        return g.activeSelf;
    }
}
