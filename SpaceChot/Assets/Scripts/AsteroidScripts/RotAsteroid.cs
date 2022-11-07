using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotAsteroid : MonoBehaviour
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
        this.transform.Translate( -velAster * Time.deltaTime,0 ,0);
        transform.Rotate(rotation * Time.deltaTime);
        Destroy(gameObject,10F);
    }
    public void CheckLife()                                                     //Checa si el jugador tiene vida
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
