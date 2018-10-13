using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

    public float minX = -60f;
    public float maxX = 60f;
    public float minY = -20f;
    public float maxY = 40f;


    public float sensX = 15f;
    public float sensY = 15f;

    public Camera PlayerCam;

    float rotY = 0f;
    float rotX = 0f;


    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        rotX += Input.GetAxis("Mouse Y") * sensX;
        rotY += Input.GetAxis("Mouse X") * sensY;

        rotX = Mathf.Clamp(rotX, minX, maxX);
        rotY = Mathf.Clamp(rotY, minY, maxY);

        PlayerCam.transform.localEulerAngles = new Vector3(-rotX, rotY, 0);
    }
}
