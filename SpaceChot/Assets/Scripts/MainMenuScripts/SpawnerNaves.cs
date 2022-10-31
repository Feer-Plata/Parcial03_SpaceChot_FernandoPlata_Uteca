using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNaves : MonoBehaviour
{
    //Atributos
    public bool PuedeSpawnear = true;
    public GameObject destroyerShip;
    public GameObject playerShip;
    private void Update()
    {
        if (PuedeSpawnear)
        {
            StartCoroutine(SpawnNaves(2f));
        }
    }

    IEnumerator SpawnNaves(float time)
    {
        Instantiate(playerShip, new Vector3(-6, 0.01f, 4), Quaternion.identity);
        Instantiate(destroyerShip, new Vector3(-6, 2, 8), Quaternion.identity);

        PuedeSpawnear = false;
        yield return new WaitForSeconds(time);
        PuedeSpawnear = true;
    }
}
