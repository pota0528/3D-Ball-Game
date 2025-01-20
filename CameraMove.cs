using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 Offset;
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }
    
    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
