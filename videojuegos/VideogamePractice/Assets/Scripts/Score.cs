// 2023-03-1: Luis Carlos Rico Almada
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] CreateBalls creator;
    
    int score;
    bool finished = false;

    void Start() { // Start is called before the first frame update
        score = 0;
    }

    public void AddPoints(int amount) { // Update is called once per frame
        if (finished == true) {
            return;
        }

        if (score == 9) {
            Finish();
            return;
        }

        score += amount;
        tmpObj.text = "Score: " + score;
    }

    public void RemovePoints(int amount) { // Update is called once per frame
        if (finished == true) {
            return;
        }

        if (score == 0) {
            GameOver();
            return;
        }

        score -= amount;
        tmpObj.text = "Score: " + score;
    }

    void Finish(){
        creator.StopBalls();
        tmpObj.text = "You won!";
        finished = true;
    }
    void GameOver(){
        creator.StopBalls();
        tmpObj.text = "You lose!";
        finished = true;
    }
}
