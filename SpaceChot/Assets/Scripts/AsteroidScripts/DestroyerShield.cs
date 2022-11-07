using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerShield : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}
