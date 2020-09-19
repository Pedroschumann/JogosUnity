using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaMorte : MonoBehaviour
{
    public static bool ataque;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Ataque"))
        {
            ataque = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Ataque"))
        {
            ataque = false;
        }
    }
}
