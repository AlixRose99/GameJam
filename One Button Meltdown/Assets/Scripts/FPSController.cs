﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSController : MonoBehaviour
{

	public float minX = -54f;
	public float maxX = 54f;
	public float minY = -130f;
	public float maxY = 130f;


	public float sensX = 5f;
	public float sensY = 5f;

	public Camera PlayerCam;

	float rotY = 0f;
	float rotX = 0f;


	// Use this for initialization
	void Start()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;

		Cursor.lockState = CursorLockMode.Locked;
		if (sceneName == "ded Screen")
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}

	// Update is called once per frame
	void Update()
	{
		rotX += Input.GetAxis("Mouse Y") * sensX;
		rotY += Input.GetAxis("Mouse X") * sensY;

		rotX = Mathf.Clamp(rotX, minX, maxX);
		rotY = Mathf.Clamp(rotY, minY, maxY);

		PlayerCam.transform.localEulerAngles = new Vector3(-rotX, rotY, 0);
	}
}