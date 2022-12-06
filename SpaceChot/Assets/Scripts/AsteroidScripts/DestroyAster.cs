using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAster : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Si el jugador toca al destructor, pierde toda la vida.
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            AudioManager.Instance.PlaySFX("Explosion");
        }
    }
}
