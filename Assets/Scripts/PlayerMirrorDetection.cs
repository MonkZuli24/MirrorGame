using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMirrorDetection : MonoBehaviour
{
    [SerializeField] private GameObject CarryingMirrorObject;
    private bool IsLookingAtMirror;
    private bool IsGrabbingMirror;
    private void Update()
    {
        float LookDistance = 1.5f;
         IsLookingAtMirror = Physics.Raycast(transform.position, transform.forward, out RaycastHit MirrorInfo, LookDistance);
        if(IsLookingAtMirror == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (MirrorInfo.transform.TryGetComponent<MirrorGrab>(out MirrorGrab Var_MirrorGrab))
                {
                    if (IsGrabbingMirror == false)
                    {
                        Var_MirrorGrab.Grabbing(transform);
                        IsGrabbingMirror = true;
                    }
                    else
                    {
                        IsGrabbingMirror = false;
                        Var_MirrorGrab.SetDown();
                    }
                    
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {         
        if(IsLookingAtMirror == true)
        {
            Vector3 OtherMirrorPosition = other.GetComponent<MirrorLocation>().GetOtherMirrorPositionPlusForward();
            Vector3 OtherMirrorLookDir = other.GetComponent<MirrorLocation>().GetOtherMirrorLookDirection();
            transform.position = new Vector3(OtherMirrorPosition.x, transform.position.y, OtherMirrorPosition.z);
            transform.forward = OtherMirrorLookDir;
        }       
    }

}

