using System.Collections; // Move a GameObject using the arrow keys or WASD
using System.Collections.Generic; // 2023-03-1: Luis Carlos Rico Almada
using UnityEngine;

public class CharacterMotion : MonoBehaviour {
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    bool up;
    bool down;
    bool left;
    bool right;
    

    void Update() { // Update is called once per frame
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y)) {
            movement.y = 0;
            if (movement.x > 0) {
                up = false;
                down = false;
                left = false;
                right = true;
            } else if (movement.x < 0) {
                up = false;
                down = false;
                left = true;
                right = false;
            }
        } else {
            movement.x = 0;
            if (movement.y > 0) {
                up = true;
                down = false;
                left = false;
                right = false;
            } else if (movement.y < 0) {
                up = false;
                down = true;
                left = false;
                right = false;
            }
        }

        if (movement.x == 0 && movement.y == 0) {
            animator.SetBool("Up",up);
            animator.SetBool("Down",down);
            animator.SetBool("Left",left);
            animator.SetBool("Right",right);
        } else {
            animator.SetBool("Up",false);
            animator.SetBool("Down",false);
            animator.SetBool("Left",false);
            animator.SetBool("Right",false);
        }

        Debug.Log(up + "" + down + "" + right + "" + left);

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.sqrMagnitude);
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}