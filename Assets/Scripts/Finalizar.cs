using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalizar : MonoBehaviour
{
    public string escena1;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(escena1);
    }
}
