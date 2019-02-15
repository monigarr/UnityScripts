using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabStuff : MonoBehaviour
{

    public GameObject rattle;
    public GameObject myHand;
    bool inHands;
    Vector3 rattlePos;

    // Start is called before the first frame update
    void Start()
    {
        rattlePos = rattle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                rattle.transform.SetParent(myHand.transform);
                rattle.transform.localPosition = myHand.transform.localPosition;
            } else if (inHands)
            {
                this.GetComponent<PickUp>().enabled = false;
                rattle.transform.SetParent(null);
                rattle.transform.localPosition = rattlePos;
                inHands = false;
            }
            
        }
    }
}
