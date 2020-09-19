using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float speed = 3; 
    public bool parar = false;  
    public void Update()
    {        
        if (transform.position.y >= -3.5 && SpawnInimigos.spawar2 == 1)
        {
            if (PlayerGalaxian.ladoDireito == false) 
            {    
                transform.Translate(5 *  -Time.deltaTime, speed *  -Time.deltaTime, 0);
            }

            if (PlayerGalaxian.ladoDireito == true)
            {
                transform.Translate(5 *  Time.deltaTime, speed *  -Time.deltaTime, 0);
            }
        }

        
        if (SpawnInimigos.destruir)
        {
            SpawnInimigos.contagem += 1;
            Destroy(gameObject);
            SpawnInimigos.destruir = false;
        }

        if (PlayerGalaxian.ladoDireito == false) 
        {    
            transform.Translate(8 *  -Time.deltaTime, 0, 0);
        }

        if (PlayerGalaxian.ladoDireito == true)
        {
            transform.Translate(8 *  Time.deltaTime, 0, 0);
        }       
        if (NaveMae.destruirCaixa)
        {
            Destroy(gameObject);
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
