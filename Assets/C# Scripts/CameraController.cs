using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 _offset;
    public Transform target;
    private float smoothTime;
    Vector3 velocity = Vector3.zero;
    
    private void Awake()
    {
        _offset = transform.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
