using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewSceneOnClick : MonoBehaviour {

	// Use this for initialization
public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
