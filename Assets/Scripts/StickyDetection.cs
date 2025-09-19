using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyDetection : MonoBehaviour
{
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        Vector3 HalfBoxSize = new Vector3(0.5f, 0.5f, 0.5f);
        bool HasHitMirror = Physics.BoxCast(transform.position, HalfBoxSize, transform.forward, out RaycastHit ObjectHitInfo);
        if (HasHitMirror)
        {
            if (ObjectHitInfo.transform.TryGetComponent<MirrorGrab>(out MirrorGrab Var_MirrorGrab))
            {
                Var_MirrorGrab.Grabbing(transform);
            }
        }
    }
}
