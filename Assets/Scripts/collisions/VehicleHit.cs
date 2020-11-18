using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleHit : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger thr script")]
    [SerializeField] string triggeringTag;
    [SerializeField] Vector3 startingPos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            this.transform.position = startingPos;
        }
    }
}
