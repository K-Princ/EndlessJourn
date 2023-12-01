using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float cameraSpeedIncreaseRate = 0.05f;

    void Update()
    {
        cameraSpeed += cameraSpeedIncreaseRate * Time.deltaTime;
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
