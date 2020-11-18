using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    [SerializeField] string NotTriggeringTag;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag != NotTriggeringTag) Destroy(other.gameObject) ;
    }
}