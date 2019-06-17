using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTester : MonoBehaviour
{
    private void Start() {
        Debug.Log(V3.AngleBetweenVectors(transform.forward, transform.right));
    }
}
