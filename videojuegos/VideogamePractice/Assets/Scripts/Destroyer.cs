using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    [SerializeField] Score scoreObj;

    void OnCollisionEnter2D(Collision2D col) {
        Destroy(col.gameObject);
        scoreObj.RemovePoints(1);
    }
}
