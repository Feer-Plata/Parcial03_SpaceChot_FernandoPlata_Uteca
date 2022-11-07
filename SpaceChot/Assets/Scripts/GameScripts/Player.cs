using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    //Atributos Jugador
    public int life;
    public Slider barraVida;
    public float speedPlayer;

    //Atributos Disparo
    public GameObject bullet;
    public List<Transform> posBullet;


    // Update is called once per frame
    void Update()
    {
        MovPlayer();
        CheckLife();
        DispararBala();
    }
    public void MovPlayer()
    {
        //Movimiento Superior.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speedPlayer * Time.deltaTime, 0);
        }
        //Movimiento a la Izquierda.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -speedPlayer * Time.deltaTime);
        }
        //Movimiento Inferior.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speedPlayer * Time.deltaTime, 0);
        }
        //Movimiento a la Derecha.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, speedPlayer * Time.deltaTime);
        }

    }
    public void CheckLife()                                                     //Checa si el jugador tiene vida
    {
        if (life <= 0)
        {
            Destroy(gameObject);                                               //Si no tiene vida, lo destruye.
            SceneManager.LoadScene(5);                                         // Abre posmortem
        }
    }

    public void DispararBala()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, posBullet[0].position, Quaternion.identity);
            Instantiate(bullet, posBullet[1].position, Quaternion.identity);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //Si el jugador toca al destructor, pierde toda la vida.
        if (other.tag == "Destroyer")
        {
            life = 0;
        }
        if (other.tag == "Enemy")
        {
            life--;
            barraVida.value = life;
        }
    }
}
