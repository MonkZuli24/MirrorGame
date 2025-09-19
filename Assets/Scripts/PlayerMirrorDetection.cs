using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMirrorDetection : MonoBehaviour
{
    private bool HitMirror;
    private void Update()
    {
         HitMirror = Physics.Raycast(transform.position, transform.forward, 2f);
    }
    private void OnTriggerEnter(Collider other)
    {         
        if(HitMirror == true)
        {
            Vector3 OtherMirrorPosition = other.GetComponent<MirrorLocation>().GetOtherMirrorPosition();
            Vector3 OtherMirrorLookDir = other.GetComponent<MirrorLocation>().GetOtherMirrorLookDirection();
            transform.position = new Vector3(OtherMirrorPosition.x, transform.position.y, OtherMirrorPosition.z);
            transform.forward = OtherMirrorLookDir;
        }       
    }
}

