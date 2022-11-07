using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTxt : MonoBehaviour
{
    //Atributos
    public Text score;
    private void Update()
    {
        score.text = "Score: " + Scoring.score;
    }
}

public class Scoring : MonoBehaviour
{
    //Atributos
    public static int score = 0;
}

