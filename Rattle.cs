using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Rattle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddListener(EventTriggerType.PointerDown, Hold);
        gameObject.AddListener(EventTriggerType.PointerUp, Release);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hold()
    {
        // get the Transform component of the pointer
        //Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;

        // set the GameObject's parent to the pointer
        //transform.SetParent(pointerTransform, false);

        // position it in the view
        //transform.localPosition = new Vector3(0, 0, 2);

        // disable physics
        //GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Release()
    {
        // set the parent to the world
        transform.SetParent(null, true);

        // get the rigidbody physics component
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // reset velocity
        rigidbody.velocity = Vector3.zero;

        // enable physics
        rigidbody.isKinematic = false;
    }
}

public static class EventExtensions
{

    public static void AddListener(this GameObject gameObject,
                                   EventTriggerType eventTriggerType,
                                   UnityAction action)
    {
        // get the EventTrigger component; if it doesn't exist, create one and add it
        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>()
                                 ?? gameObject.AddComponent<EventTrigger>();

        // check to see if the entry already exists
        EventTrigger.Entry entry;
        entry = eventTrigger.triggers.Find(e => e.eventID == eventTriggerType);

        if (entry == null)
        {
            // if it does not, create and add it
            entry = new EventTrigger.Entry { eventID = eventTriggerType };

            // add the entry to the triggers list
            eventTrigger.triggers.Add(entry);
        }

        // add the callback listener
        entry.callback.AddListener(_ => action());
    }

}
