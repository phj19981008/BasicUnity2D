using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //속도값 

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(speed / 50, 0, 0); //수평이동        
    }
}
