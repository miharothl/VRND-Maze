using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;


	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
    	Debug.Log ("OnKeyClicked() was called");

		// Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		Instantiate (keyPoofPrefab, transform.position, transform.rotation);
    
        // Destroy this key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);

		door.Unlock ();
    }

}
