using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//add this script to empty game object in scene
//add buttons to the scene
//pull empty game object sceneloading onto button
//add navigation event to button for the relevant scene in inspector

public class SceneLoading : MonoBehaviour {

    public Material LonghouseEntry;
    public Material LonghouseCenter;
    public Material LonghouseTopRafter;
    public Material LonghouseBottomRafter;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartLonghouseVR()
    {
        SceneManager.LoadScene("StartLonghouseVR");
    }

    public void SaintAnicet_CenterVillage()
    {
        SceneManager.LoadScene("SaintAnicet_CenterVillage");
    }

    public void SaintAnicet_WolfLonghouse_Center()
    {
        SceneManager.LoadScene("SaintAnicet_WolfLonghouse_Center");
    }

    public void SaintAnicet_WolfLonghouse_EastDoor()
    {
        SceneManager.LoadScene("SaintAnicet_WolfLonghouse_EastDoor");
    }

    public void SaintAnicet_WolfLonghouse_WestDoor()
    {
        SceneManager.LoadScene("SaintAnicet_WolfLonghouse_WestDoor");
    }

    public void IroquoisVillageMiniatureVideo()
    {
        SceneManager.LoadScene("IroquoisVillageMiniatureVideo");
    }

    public void LonghouseNYMuseum()
    {
        SceneManager.LoadScene("LonghouseNYMuseum");
    }

    public void LonghouseNYMuseumEnter()
    {
        SceneManager.LoadScene("LonghouseEntry");
    }

    public void LonghouseNYMuseumCenter()
    {
        SceneManager.LoadScene("LonghouseCenter");
    }

    public void LonghouseNYMuseumPeopleBottomRafter()
    {
        SceneManager.LoadScene("LonghouseBottomRafter");
    }

    public void LonghouseNYMuseumPeopleTopRafter()
    {
        SceneManager.LoadScene("LonghouseTopRafter");
    }

    public void ADNYMuseum()
    {
        SceneManager.LoadScene("1600ADNYMuseum");
    }

    public void RattleBasket()
    {
        SceneManager.LoadScene("RattleBasket");
    }

}
