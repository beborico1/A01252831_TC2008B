using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisions : MonoBehaviour
{

    public Gem gem1;
    public Gem gem2;
    public Gem gem3;
    public Gem gem4;

    public GameObject felicidades;
    public GameObject insuficiente;

    public GameObject perdiste;
    
    
    public Score scoreObj;

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Demon") {
            Debug.Log("Perdiste");
            transform.position = new Vector3(-9, 0, 0);
            gem1.RestartPosition();
            gem2.RestartPosition();
            gem3.RestartPosition();
            gem4.RestartPosition();
            if (perdiste.transform.position.z < 0) {
                perdiste.transform.Translate(0, 0, 10);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "teus") {
            Debug.Log("TEUS");
            if (scoreObj.score == 4) {
                if (felicidades.transform.position.z < 0) {
                    felicidades.transform.Translate(0, 0, 20);
                }
            } else {
                if (insuficiente.transform.position.z < 0) {
                    insuficiente.transform.Translate(0, 0, 15);
                }
            }
        }
    }
}
