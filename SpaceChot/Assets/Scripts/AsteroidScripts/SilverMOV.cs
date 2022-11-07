using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverMOV : MonoBehaviour
{
    //Atributos rotacion y movimiento
    public int vidaAster;
    public float velAster;
    public int vRotacion;
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        CheckLife();
        this.transform.Translate(0, velAster * Time.deltaTime, 0);
        transform.Rotate(rotation * Time.deltaTime);
        Destroy(gameObject,10f);
    }
    public void CheckLife()                                                   
    {
        if (vidaAster <= 0)
        {
            Scoring.score++;
            Debug.Log("Suma al score");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            vidaAster--;
        }

        if (other.tag == "PlayerBullet")
        {
            vidaAster--;
        }
    }
}
