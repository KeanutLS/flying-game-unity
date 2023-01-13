using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float cameraSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(cameraSpeed*Time.deltaTime, 0, 0);
    }
}
