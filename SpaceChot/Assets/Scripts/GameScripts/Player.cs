using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Atributos Jugador
    public int life;
    public Slider barraVida;
    public float speedPlayer;

    //public GameObject bala;
    //public List<Transform> posicionesBala;


    // Update is called once per frame
    void Update()
    {
        MovPlayer();
        CheckLife();
        Bajarvida();
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

    public void Bajarvida()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Baja vida");
            life--;
            barraVida.value = life;
        }
    }
}
