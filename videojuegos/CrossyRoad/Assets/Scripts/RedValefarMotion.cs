using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedValefarMotion : MonoBehaviour {
    [SerializeField] float speed;
    bool goingUP = false;

    // void Start() { // Start is called before the first frame update
        
    // }
    void Update() { // Update is called once per frame
        if ( transform.position.y > 8 ) {
            goingUP = false;
        }

        if ( transform.position.y < -8 ) {
            goingUP = true;
        }

        if (goingUP) {
            transform.Translate(0, speed * Time.deltaTime, 0);
        } else {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }
}
