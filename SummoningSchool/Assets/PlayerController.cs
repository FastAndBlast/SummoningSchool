using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform cameraTransform;

    public PlayerController()
    {
        
    }

    private void Update()
    {
        Vector3 movementDelta = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        Vector3 directionalDelta = movementDelta.x * cameraTransform.right + movementDelta.z * cameraTransform.forward;

        directionalDelta.y = 0;
        directionalDelta.Normalize();

        transform.position += directionalDelta * speed * Time.deltaTime;

        
    }



}
