using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoof : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject Poof;

	public void OnCoinClicked() {
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		//transform.something coinPoofPrefab here
		Object.Instantiate(Poof, transform.position, Quaternion.Euler (270, 0, 0));


		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
	}
}
