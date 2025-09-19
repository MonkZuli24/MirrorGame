using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 MaxMoveSideA;
    [SerializeField] private Vector3 MaxMoveSideB;
    [SerializeField] private float MoveSpeed;
    private Vector3 MovingSide;
    private void Start()
    {
        MaxMoveSideA = transform.position;
        MovingSide = MaxMoveSideB;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MovingSide, MoveSpeed * Time.deltaTime);
        if(transform.position == MovingSide)
        {
            if(MovingSide == MaxMoveSideB)
            {
                MovingSide = MaxMoveSideA;
            }
            else
            {
                MovingSide = MaxMoveSideB;
            }
        }
    }
}
