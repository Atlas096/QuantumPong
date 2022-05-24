using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBottomTop : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
                // transform the world forward into local space:
        Vector3 relative;
        relative = transform.InverseTransformDirection(Vector3.forward);
    }
}
