using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDestructor : MonoBehaviour
{
    //Atributos
    public float vDestroyer;
    public int vRotacion = 10;
    public Vector3 rotation;


    // Update is called once per frame
    void Update()
    {
        MovDestroyer();
        transform.Rotate(rotation * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
    public void MovDestroyer()
    {
        this.transform.Translate(0, 0, vDestroyer * Time.deltaTime);
    }
}
