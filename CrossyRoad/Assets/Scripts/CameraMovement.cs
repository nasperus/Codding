using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] float speed = 0.125f;
    [SerializeField] Vector3 offset;


    
    void Update()
    {
        Vector3 x = target.position + offset;
        Vector3 y = Vector3.Lerp(transform.position, x, speed);
        transform.position = y;
    }

}
