using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCollider : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("Canasta!"); // Esto es como un print
    }
}
