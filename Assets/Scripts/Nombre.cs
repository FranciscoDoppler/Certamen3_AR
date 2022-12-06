using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nombre : MonoBehaviour
{

    public TMPro.TMP_InputField input;
    public string escena;
    public void getData()
    {
        string nombre = input.text;
        
        if (string.IsNullOrEmpty(nombre))
        {
            Debug.Log("No guardo nombre");
        }
        else
        {
            Debug.Log("Su Nombre es: " + nombre);
            PlayerPrefs.SetString("nombre", nombre);
            SceneManager.LoadScene(escena);
        }
    }
}

