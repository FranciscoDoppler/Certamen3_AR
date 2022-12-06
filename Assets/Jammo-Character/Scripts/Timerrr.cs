using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timerrr : MonoBehaviour
{
    int Contador = 30;
    public Text timerUI;
    public string escena12;

    void Start()
    {
        terminarContador();
    }
    void terminarContador()
    {

        if (Contador > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(Contador);
            timerUI.text = "Timer: " + spanTime.Seconds;
            Contador--;
            Invoke("terminarContador", 1.0f);

        }
        else
        {
            timerUI.text = "GameOver!";
            SceneManager.LoadScene(escena12);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
