using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject Poof;
	public Door door;
	public static bool hasKey;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		Instantiate(Poof, transform.position, Quaternion.Euler (270, 0, 0));

		hasKey = true;

		UnlockDoor ();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		// anything after this will not be happening
		Destroy(gameObject);

	}

	public void UnlockDoor(){
		door.GetComponent<Door>().Unlock();
		door.Unlock ();
	}
}
