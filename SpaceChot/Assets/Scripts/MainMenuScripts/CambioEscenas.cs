using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioEscenas : MonoBehaviour
{
    public void BackMenu()
    {
        //Carga el menu principal.
        SceneManager.LoadScene(0);
    }
    public void Iniciar()
    {
        //Carga el juego.
        Scoring.score = 0;
        SceneManager.LoadScene(1);

    }
    public void ReIniciar()
    {
        //Carga el juego.
        Scoring.score = 0;
        SceneManager.LoadScene(1);

    }
    public void SettingsMenu()
    {
        //Carga escena de configuraciones.
        SceneManager.LoadScene(2);
    }
    public void Finalizar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
    public void CtrlMenu()
    {
        //Carga el Menu de controles.
        SceneManager.LoadScene(3);
    }
    public void CreditsMenu()
    {
        //Carga el Menu de creditos.
        SceneManager.LoadScene(4);
    }
    public void CtrlASettings()
    {
        //Carga el Menu de configuracion.
        SceneManager.LoadScene(2);
    }
    public void CreditsASettings()
    {
        //Carga el Menu de configuracion.
        SceneManager.LoadScene(2);
    }
    public void SettingsAPrincipal()
    {
        //Carga el Menu principal.
        SceneManager.LoadScene(0);
    }
}
