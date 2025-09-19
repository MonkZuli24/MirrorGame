using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorLocation : MonoBehaviour
{
    [SerializeField] private Transform ConnectedMirrorTransform;
    public Vector3 GetOtherMirrorPositionPlusForward()
    {
     return ConnectedMirrorTransform.position + ConnectedMirrorTransform.forward;   
    }
    public Vector3 GetOtherMirrorLookDirection()
    {
        return ConnectedMirrorTransform.forward;
    }
}
