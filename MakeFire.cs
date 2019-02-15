using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFire : MonoBehaviour
{

    public GameObject FlamesParticleEffect;
    public GameObject RibbonSmoke;

    public void AddFlames()
    {
        Instantiate(FlamesParticleEffect, Vector3.zero, Quaternion.identity);
    }

    public void addSmoke()
    {
        Instantiate(RibbonSmoke, Vector3.zero, Quaternion.identity);
    }

    public void OnFirePitClicked()
    {
        // Instantiate the Fire Prefab where this coin is located
        // Make sure the poof animates vertically
        //transform.something coinPoofPrefab here
        Object.Instantiate(FlamesParticleEffect, transform.position, Quaternion.Euler(270, 0, 0));
        Object.Instantiate(RibbonSmoke, transform.position, Quaternion.Euler(270, 0, 0));
    }

    public void OnFirePitOff()
    {
        // Destroy the fire and smoke prefabs
        Destroy(FlamesParticleEffect);
        Destroy(RibbonSmoke);
    }
}
