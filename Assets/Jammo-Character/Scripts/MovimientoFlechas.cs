using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFlechas : MonoBehaviour
{
    public CharacterController controller;
    public float velocidad;

    private bool Forward;
    private bool Forwardnt;
    private bool Left;
    private bool Right;

    private void Update()
    {
        if (Forward == true)
        {
            controller.Move(transform.forward * velocidad * Time.deltaTime);
        }
        if (Forwardnt == true)
        {
            controller.Move(-transform.forward * velocidad * Time.deltaTime);
        }
        if (Right == true)
        {
            controller.Move(transform.right * velocidad * Time.deltaTime);
        }
        if (Left == true)
        {
            controller.Move(-transform.right * velocidad * Time.deltaTime);
        }
    }

    public void MoveForward()
    {
        Forward = true;
    }
    public void MoveForwardnt()
    {
        Forwardnt = true;
    }
    public void MoverDerecha()
    {
        Right = true;
    }
    public void MoverIzquierda()
    {
        Left = true;
    }


    public void desactivar()
    {
        Forward = false;
        Forwardnt = false;
        Right = false;
        Left = false;
    }
}
