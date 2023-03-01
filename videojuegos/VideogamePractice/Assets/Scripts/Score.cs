using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    int score;

    void Start() { // Start is called before the first frame update
        score = 0;
    }

    public void AddPoints(int amount) { // Update is called once per frame
        score += amount;
        Debug.log("New score: " + score);
    }
}
