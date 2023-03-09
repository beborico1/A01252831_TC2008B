// Detect the ball when it goes in
// 2023-03-1: Luis Carlos Rico Almada
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIn : MonoBehaviour {
    [SerializeField] Score scoreObj;

    void OnCollisionEnter2D(Collision2D col) { // Detect the element in contact
        Debug.Log("Canasta!"); // Esto es como un print
        scoreObj.AddPoints(1);
        Destroy(col.gameObject);
    }
}
