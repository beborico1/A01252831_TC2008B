// Move a GameObject using the arrow keys or AD

// Luis Carlos Rico Almada
// 2023-03-1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMotion : MonoBehaviour {
    [SerializeField] float speed;

    Vector3 move;

    void Start() { // Start is called before the first frame update
        
    }

    void Update() { // Update is called once per frame
        move.x = Input.GetAxis("Horizontal");

        Debug.Log("X motion: " + move.x); // Esto es como un print

        transform.Translate(move * speed * Time.deltaTime);
    }
}
