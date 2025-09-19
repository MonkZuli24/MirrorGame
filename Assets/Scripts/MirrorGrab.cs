using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorGrab : MonoBehaviour
{
    private bool IsBeingGrabbed;
    private Transform ObjectGrabbingMirror;
    private Vector3 FacingDirection;
    
    private void Update()
    {
        if (IsBeingGrabbed)
        {
            Vector3 MirrorGrabPosition = ObjectGrabbingMirror.position + ObjectGrabbingMirror.forward;
            transform.position = MirrorGrabPosition;            
            transform.forward = ObjectGrabbingMirror.forward; //FACING AWAY OR TOWARDS THE OBJECT GRABBING IT
        }
    }
    public void Grabbing(Transform ObjectGrabbingTransform)
    {
        if(IsBeingGrabbed == false)
        {
            IsBeingGrabbed = true;
            this.ObjectGrabbingMirror = ObjectGrabbingTransform;
        }
    }
    public void SetDown()
    {
        IsBeingGrabbed = false;
    }
}
