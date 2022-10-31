using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPlayerShip : MonoBehaviour
{
    //Atributos
    public float vPlayerShip;
    public int vRotacion;
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        MovPlayerShip();
        transform.Rotate(rotation * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
    public void MovPlayerShip()
    {
        this.transform.Translate(0, 0, vPlayerShip * Time.deltaTime);
    }
}
