using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliders : MonoBehaviour {
    public Collider coll;
    // Use this for initialization
    void Start () {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false; 
    }
}
