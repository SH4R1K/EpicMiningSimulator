using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlWorking : MonoBehaviour {

    public NavMeshAgent agent;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
	}

    void ForMine(Transform transform)
    {

    }
}
