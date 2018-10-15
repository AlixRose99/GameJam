using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    Camera cam;
    GameObject[] buttons;
    GameObject CurrentButton;
    int index;

    void Start()
    {
        cam = GetComponent<Camera>();

        buttons = GameObject.FindGameObjectsWithTag("BUTTON");
        index = Random.Range(0, buttons.Length);
        CurrentButton = buttons[index];
        print(CurrentButton.name);

    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            print("I'm looking at " + hit.transform.name);
        else
            print("I'm looking at nothing!");
    }
}