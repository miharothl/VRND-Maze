﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;

    public void OnCoinClicked() {

		// Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
		Debug.Log ("OnCoinClicked() was called");

		Instantiate (coinPoofPrefab, transform.position, transform.rotation);
    
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }
}
