using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour {

    public float Speed;
    private Transform Camera;

    private void Start()
    {
        Camera = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 PositionCamera = Camera.transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            PositionCamera.x = PositionCamera.x + Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PositionCamera.x = PositionCamera.x - Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            PositionCamera.z = PositionCamera.z + Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PositionCamera.z = PositionCamera.z - Speed * Time.deltaTime;
        }

        Camera.transform.position = PositionCamera;
    }
}
