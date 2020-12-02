using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int scorePoints = 0;
    private Text score;
    private int vidas=0;

    private void Start()
    {
        score = GetComponent<Text>();
        EventManager.current.onPickUp += addPoints;
        EventManager.current.onContact += reduceHP;
    }

    //debemos tenerlo en cuenta el mojon de cara al contador, 3 mojones equivalen una vida
    private void addPoints()
    {
        scorePoints = scorePoints + 1;
        if (scorePoints==3)
        {
            vidas += 1;
            scorePoints = 0;
        }
        score.text = "Vidas:" + vidas;
    }
    //si un enemigo nos toca, deberemos restar una vida
    private void reduceHP()
    {
        vidas -= 1;
        score.text = "Vidas:" + vidas;
        if (vidas < 0)
        {
            EventManager.current.death();
        }
    }

}
