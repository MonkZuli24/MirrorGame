using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorGrab : MonoBehaviour
{
    private bool IsBeingGrabbed;
    private Transform PlayerTransform;
    private void Update()
    {
        if (IsBeingGrabbed)
        {

            Vector3 MirrorGrabPosition = PlayerTransform.position + PlayerTransform.forward;
            transform.position = MirrorGrabPosition;            
            transform.forward = -PlayerTransform.forward;
        }
    }
    public void Grabbing(Transform PlayerTransform)
    {
        IsBeingGrabbed = true;
        this.PlayerTransform = PlayerTransform;
    }
    public void SetDown()
    {
        IsBeingGrabbed = false;
    }
}
