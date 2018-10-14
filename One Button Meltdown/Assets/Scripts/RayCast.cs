using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RayCast : MonoBehaviour
{
<<<<<<< HEAD
	public Camera camera;
	RaycastHit hit;

	void Update()
	{

		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit))
		{
			Transform objectHit = hit.transform;

			print(objectHit.tag);
		}
	}
}

=======
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
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
>>>>>>> tish
