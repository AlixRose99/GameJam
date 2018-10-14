using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwing : MonoBehaviour {

    public Light lt;
    public int speed = 100;
	
	// Update is called once per frame
	void Update () {
        lt.transform.Rotate(0, Time.deltaTime * speed, 0, Space.World);
    }
}
