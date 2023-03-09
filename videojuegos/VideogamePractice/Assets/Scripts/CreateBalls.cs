// 2023-03-1: Luis Carlos Rico Almada
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour {
    [SerializeField] GameObject ball; // Serialize Field hace que se pueda ver desde la interfaz de Unity
    [SerializeField] float delay; // Serialize Field hace que se pueda ver desde la interfaz de Unity

    void Start() { // Start is called before the first frame update
        InvokeRepeating("DropBall", 0.5f, delay); // Call the "DropBall" function after 0.5 seconds and then keep calling it every 0.8 seconds
    }

    void DropBall() {
        Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 6, 0); // Generate a new random position
        GameObject obj = Instantiate(ball, pos, Quaternion.identity); // Create a copy of the prefab
    }

    public void StopBalls() {
        CancelInvoke();
    }
}
