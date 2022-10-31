using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDestructor : MonoBehaviour
{
    //Atributos
    public float speedDesplace;
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > -8)
        {
            this.transform.position = new Vector3(-25, 0, 0);
        }
        transform.Translate(0, 0, speedDesplace * Time.deltaTime);

    }
}
