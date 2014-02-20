using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Just a holder to identify pooled objects, however ObjectPoolManager will destroy either
// Identification for GetComponentsInChildren<T>(true) for finding while inactive.

public class PoolGameObject : MonoBehaviour {    

    public bool pooled = true;

    void Start() {
    
    }
}
