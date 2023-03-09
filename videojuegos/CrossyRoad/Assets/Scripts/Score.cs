using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {
    [SerializeField] TMP_Text tmpObj;
    public int score = 0;

    void Update() {
        tmpObj.text = "Gemas: " + score + "/4";
    }
    public void AddPoint() {
        ++score;
    }

    public void RestartScore() {
        score = 0;
    }
}
