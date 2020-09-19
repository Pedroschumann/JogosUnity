using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoInicial : MonoBehaviour
{
    private float movimento = 8;
    public float speed = 3; 

    public void Update()
    {        
        if (SpawnInimigos.destruir)
        {
            Destroy(gameObject);
            SpawnInimigos.destruir = false;

        }

        if (PlayerGalaxian.ladoDireito == false) 
        {    
            transform.Translate(movimento *  -Time.deltaTime, 0, 0);
        }

        if (PlayerGalaxian.ladoDireito == true)
        {
            transform.Translate(movimento *  Time.deltaTime, 0, 0);
        }       
    }
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.CompareTag("ParedeDireita"))
        {
            PlayerGalaxian.ladoDireito = false;
        }

        if(collisor.gameObject.CompareTag("ParedeEsquerda"))
        {
            PlayerGalaxian.ladoDireito = true;
        }
    }
}
