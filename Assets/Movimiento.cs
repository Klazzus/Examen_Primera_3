using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    float Izq = 1;
    float Der = -1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Caida = new Vector3(0, -0.01f, 0);
        transform.Translate(Caida);
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(new Vector3(Izq, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(Der, 0, 0));
        }


    }
}
