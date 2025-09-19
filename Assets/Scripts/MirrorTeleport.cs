using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorLocation : MonoBehaviour
{
    [SerializeField] private Transform ConnectedMirrorTransform;
    public Vector3 GetOtherMirrorPosition()
    {
     return ConnectedMirrorTransform.position;   
    }
    public Vector3 GetOtherMirrorLookDirection()
    {
        return transform.forward;
    }
}
