using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MouseVisible : MonoBehaviour
{
	void Start()
	{
		// Create a temporary reference to the current scene.
		Scene currentScene = SceneManager.GetActiveScene();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;

		if (sceneName == "ded Screen")
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}