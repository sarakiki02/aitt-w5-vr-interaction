using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GrabbingScript : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.Any))
        {
            GameObject thingBeingGrabbed = other.gameObject;
            thingBeingGrabbed.transform.parent = transform;
            rb = thingBeingGrabbed.GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }

        if (SteamVR_Input.GetStateUp("GrabPinch", SteamVR_Input_Sources.Any))
        {
            GameObject thingBeingGrabbed = other.gameObject;
            thingBeingGrabbed.transform.parent = null;
            rb = thingBeingGrabbed.GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }
    }
}
