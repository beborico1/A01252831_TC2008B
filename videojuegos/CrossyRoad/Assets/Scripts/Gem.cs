using System.Collections; // Move a GameObject using the arrow keys or WASD
using System.Collections.Generic; // 2023-03-1: Luis Carlos Rico Almada
using UnityEngine;

public class Gem : MonoBehaviour {
    float x;
    float y;
    public Score score;

    void Start () {
        x = transform.position.x;
        y = transform.position.y;
    }

    void OnTriggerEnter2D() {
        transform.Translate(0, -15, 0);
        score.AddPoint();
    }

    public void RestartPosition() {
        transform.position =  new Vector3(x, y, 0);
        score.RestartScore();
    }
}