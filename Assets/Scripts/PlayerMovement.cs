using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    private Vector3 MoveDirection;
    private void Update()
    {
        MoveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            MoveDirection = transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveDirection = -transform.forward;
        }
        if (Input.GetKey(KeyCode.A)) //POTENTIAL FRAME DEPENDANT
        {
            Vector3 LeftRotation = new Vector3(0f, -1f, 0f);
            transform.Rotate(LeftRotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 RightRotation = new Vector3(0f, 1f, 0f);
            transform.Rotate(RightRotation);
        }

        MoveDirection.Normalize();

        if(MoveDirection != Vector3.zero)
        {            
            transform.position = transform.position + MoveDirection * MoveSpeed * Time.deltaTime;
        }
        Debug.DrawRay(transform.position, transform.forward, Color.red);
    }
}
