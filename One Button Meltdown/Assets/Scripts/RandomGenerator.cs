using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
	GameObject[] buttons;
	GameObject CurrentButton;
	int index;

	public void Start()
	{
		buttons = GameObject.FindGameObjectsWithTag("Button");
		index = Random.Range(0, buttons.Length);
		CurrentButton = buttons[index];
		print (CurrentButton.name);
	}
}