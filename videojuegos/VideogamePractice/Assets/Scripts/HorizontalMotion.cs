// Move a GameObject using the arrow keys or AD

// Luis Carlos Rico Almada
// 2023-03-1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMotion : MonoBehaviour {
    [SerializeField] float speed;
    [SerializeField] float limit;
    
    Vector3 move;

    void Start() { // Start is called before the first frame update
        
    }

    void Update() { // Update is called once per frame
        move.x = Input.GetAxis("Horizontal");

        //Limit the motion to a specific range of coordinates
        if (transform.position.x < limit && move.x < 0) {
            move.x = 0;
        } else if  (transform.position.x > limit && move.x > 0) {
            move.x = 0;
        }

        Debug.Log("X motion: " + move.x); // Esto es como un print

        transform.Translate(move * speed * Time.deltaTime);
    }
}
