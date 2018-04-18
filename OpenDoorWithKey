using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWithKey : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool Locked;
	public bool open;
	public AudioClip openDoor;
	public AudioClip closeDoor;
	public AudioSource doorAudioSource;


	void Start(){
		Locked = true;
		open = false;
	}

    public void Unlock()
    {
		if(Key.hasKey == true){
			//open = true;
			Locked = false;
			doorAudioSource.clip = openDoor;
			doorAudioSource.Play ();
			//Locked = !Locked;
		}
    }

	public void onDoorClicked(){
		if (!Locked) {
			open = true;
			doorAudioSource.clip = openDoor;
			doorAudioSource.Play ();
		} else {
			open = false;
			doorAudioSource.clip = closeDoor;
			doorAudioSource.Play ();
		}
	}

	void Update() {
		//open door if its not locked & user clicked on it.
		if(open){
			Debug.Log (transform.position.y);
			//why is Only mesh renderer 
			if(transform.position.y >= -23.2f) {
				transform.Translate(0, Time.deltaTime, 0, Space.World);
				//make door disappear when it goes up inside the temple
				//just before it can start showing over the top of the temple
				if (transform.position.y >= 13.0f) {
					Destroy (gameObject);
				}
			}
		}
	}
