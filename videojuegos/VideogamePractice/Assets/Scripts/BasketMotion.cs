// Move a GameObject using the arrow keys or AD
// 2023-03-1: Luis Carlos Rico Almada
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMotion : MonoBehaviour {
    [SerializeField] float speed;
    [SerializeField] float limitX;
    [SerializeField] float limitY;
    Vector3 move;
    void Update() { // Update is called once per frame
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        if (transform.position.x < -limitX && move.x < 0) { //Limit the motion to a specific range of coordinates
            move.x = 0;
        } else if  (transform.position.x > limitX && move.x > 0) {
            move.x = 0;
        }

        if (transform.position.y < -limitY && move.y < 0) { //Limit the motion to a specific range of coordinates
            move.y = 0;
        } else if  (transform.position.y > limitY && move.y > 0) {
            move.y = 0;
        }


        transform.Translate(move * speed * Time.deltaTime);
    }
}
