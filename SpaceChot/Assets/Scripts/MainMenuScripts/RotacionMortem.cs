using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMortem : MonoBehaviour
{
    //Atributos
    public float vPlayerShip;
    public int vRotacion;
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        this.transform.Translate(0, 0, vPlayerShip * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
    }
    public void MovimientoJugador()
    {
        if (this.transform.position.x < -12)
        {
            this.transform.position = new Vector3(0, 0, 10f);
        }
        else if (this.transform.position.x >= 12)
        {
            this.transform.position = new Vector3(0, 0, 10f);
        }
        if (this.transform.position.y < -10)
        {
            this.transform.position = new Vector3(0, 0, 10f);
        }
        else if (this.transform.position.y >= 10)
        {
            this.transform.position = new Vector3(0, 0, 10f);
        }
    }
}
