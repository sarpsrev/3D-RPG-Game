using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("Camera Movement")]
    [SerializeField] private  Transform target;
    [SerializeField] private  Vector3 offset;
    [SerializeField] private float turnInput=0f;
    [SerializeField] private float turnSpeed=100f;

    [Header("Camera Zoom")]
    [SerializeField] private float currentZoom = 10f;
    [SerializeField] private  float minZoom = 7f;
    [SerializeField] private float maxZoom = 10f;
    [SerializeField] private float zoomSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentZoom += Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom,minZoom,maxZoom);

        if (Input.GetMouseButton(1))
        {
            turnInput -= Input.GetAxis("Mouse X")*turnSpeed*Time.deltaTime;
        }

        

    }

    void LateUpdate()
    {
        transform.position = target.position-offset*currentZoom;
        transform.LookAt(target.position + Vector3.up);

        transform.RotateAround(target.position,Vector3.up,turnInput);
    }
}
