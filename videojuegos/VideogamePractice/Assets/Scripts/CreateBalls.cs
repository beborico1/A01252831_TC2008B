using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    // Class variable to be changed from the Unity interface
    [SerializeField] GameObject ball; // Serialize Field hace que se pueda ver desde la interfaz de Unity

    // Start is called before the first frame update
    void Start()
    {
        // Call the "DropBall" function after 0.5 seconds
        // and then keep calling it every 0.8 seconds
        InvokeRepeating("DropBall()", 0.5f, 0.8f);
    }

    void DropBall() 
    {
        Instantiate(ball);
    }
}
